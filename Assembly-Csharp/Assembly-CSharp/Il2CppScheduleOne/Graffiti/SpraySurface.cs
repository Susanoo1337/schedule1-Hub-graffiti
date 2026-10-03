using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x0200036F RID: 879
	public class SpraySurface : NetworkBehaviour
	{
		// Token: 0x06004A4B RID: 19019 RVA: 0x00177DA4 File Offset: 0x00175FA4
		// Note: this type is marked as 'beforefieldinit'.
		static SpraySurface()
		{
			Il2CppClassPointerStore<SpraySurface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "SpraySurface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr);
			SpraySurface.NativeFieldInfoPtr_PIXEL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "PIXEL_SIZE");
			SpraySurface.NativeFieldInfoPtr__CurrentEditor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "<CurrentEditor>k__BackingField");
			SpraySurface.NativeFieldInfoPtr__ContainsCartelGraffiti_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "<ContainsCartelGraffiti>k__BackingField");
			SpraySurface.NativeFieldInfoPtr_Editable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "Editable");
			SpraySurface.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "Width");
			SpraySurface.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "Height");
			SpraySurface.NativeFieldInfoPtr_FalloffCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "FalloffCurve");
			SpraySurface.NativeFieldInfoPtr_IsVandalismSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "IsVandalismSurface");
			SpraySurface.NativeFieldInfoPtr_BottomLeftPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "BottomLeftPoint");
			SpraySurface.NativeFieldInfoPtr_Projector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "Projector");
			SpraySurface.NativeFieldInfoPtr_drawing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "drawing");
			SpraySurface.NativeFieldInfoPtr_cachedDrawing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "cachedDrawing");
			SpraySurface.NativeFieldInfoPtr_onDrawingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "onDrawingChanged");
			SpraySurface.NativeFieldInfoPtr_pastRequestIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "pastRequestIDs");
			SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted");
			SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted");
			SpraySurface.NativeMethodInfoPtr_get_CurrentEditor_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672805);
			SpraySurface.NativeMethodInfoPtr_set_CurrentEditor_Private_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672806);
			SpraySurface.NativeMethodInfoPtr_get_DrawingStrokeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672807);
			SpraySurface.NativeMethodInfoPtr_get_DrawingOutputTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672808);
			SpraySurface.NativeMethodInfoPtr_get_DrawingPaintedPixelCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672809);
			SpraySurface.NativeMethodInfoPtr_set_DrawingPaintedPixelCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672810);
			SpraySurface.NativeMethodInfoPtr_get_RoundedWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672811);
			SpraySurface.NativeMethodInfoPtr_get_RoundedHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672812);
			SpraySurface.NativeMethodInfoPtr_get_ContainsCartelGraffiti_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672813);
			SpraySurface.NativeMethodInfoPtr_set_ContainsCartelGraffiti_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672814);
			SpraySurface.NativeMethodInfoPtr_get_TopRightPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672815);
			SpraySurface.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672816);
			SpraySurface.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672817);
			SpraySurface.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672818);
			SpraySurface.NativeMethodInfoPtr_ResizeProjector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672819);
			SpraySurface.NativeMethodInfoPtr_CanBeEdited_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672820);
			SpraySurface.NativeMethodInfoPtr_CanUndo_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672821);
			SpraySurface.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672822);
			SpraySurface.NativeMethodInfoPtr_ReplicateTo_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672823);
			SpraySurface.NativeMethodInfoPtr_SetCurrentEditor_Server_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672824);
			SpraySurface.NativeMethodInfoPtr_SetCurrentEditor_Client_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672825);
			SpraySurface.NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672826);
			SpraySurface.NativeMethodInfoPtr_AddStrokes_Server_Public_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672827);
			SpraySurface.NativeMethodInfoPtr_AddStrokes_Client_Private_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672828);
			SpraySurface.NativeMethodInfoPtr_AddTextureToHistory_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672829);
			SpraySurface.NativeMethodInfoPtr_AddTextureToHistory_Client_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672830);
			SpraySurface.NativeMethodInfoPtr_CacheDrawing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672831);
			SpraySurface.NativeMethodInfoPtr_PrintHistoryCount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672832);
			SpraySurface.NativeMethodInfoPtr_Undo_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672833);
			SpraySurface.NativeMethodInfoPtr_Undo_Client_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672834);
			SpraySurface.NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672835);
			SpraySurface.NativeMethodInfoPtr_ClearDrawing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672836);
			SpraySurface.NativeMethodInfoPtr_EnsureDrawingExists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672837);
			SpraySurface.NativeMethodInfoPtr_CreateNewDrawing_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672838);
			SpraySurface.NativeMethodInfoPtr_RestoreFromCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672839);
			SpraySurface.NativeMethodInfoPtr_ToWorldPosition_Public_Vector3_UShort2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672840);
			SpraySurface.NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672841);
			SpraySurface.NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672842);
			SpraySurface.NativeMethodInfoPtr_DrawingChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672843);
			SpraySurface.NativeMethodInfoPtr_GetSerializedDrawing_Public_SerializedGraffitiDrawing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672844);
			SpraySurface.NativeMethodInfoPtr_LoadSerializedDrawing_Public_Void_SerializedGraffitiDrawing_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672845);
			SpraySurface.NativeMethodInfoPtr_WillDrawingFit_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672846);
			SpraySurface.NativeMethodInfoPtr_GetPadding_Public_Static_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672847);
			SpraySurface.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672848);
			SpraySurface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672849);
			SpraySurface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672850);
			SpraySurface.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672851);
			SpraySurface.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672852);
			SpraySurface.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672853);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_SetCurrentEditor_Server_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672854);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Server_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672855);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Server_SetCurrentEditor_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672856);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672857);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672858);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672859);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Target_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672860);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Target_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672861);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_AddStrokes_Server_1511871282_Private_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672862);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___AddStrokes_Server_1511871282_Public_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672863);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Server_AddStrokes_Server_1511871282_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672864);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672865);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672866);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_AddStrokes_Client_1511871282_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672867);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_AddTextureToHistory_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672868);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672869);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Server_AddTextureToHistory_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672870);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_AddTextureToHistory_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672871);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672872);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_AddTextureToHistory_Client_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672873);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_Undo_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672874);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___Undo_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672875);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Server_Undo_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672876);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Undo_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672877);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___Undo_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672878);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Undo_Client_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672879);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_ClearDrawing_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672880);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___ClearDrawing_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672881);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Server_ClearDrawing_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672882);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672883);
			SpraySurface.NativeMethodInfoPtr_RpcLogic___Set_4105842735_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672884);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Set_4105842735_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672885);
			SpraySurface.NativeMethodInfoPtr_RpcWriter___Target_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672886);
			SpraySurface.NativeMethodInfoPtr_RpcReader___Target_Set_4105842735_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672887);
			SpraySurface.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr, 100672888);
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x001785A4 File Offset: 0x001767A4
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x001785E4 File Offset: 0x001767E4
		public unsafe NetworkObject CurrentEditor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_CurrentEditor_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_set_CurrentEditor_Private_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00178628 File Offset: 0x00176828
		public unsafe int DrawingStrokeCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 169796, RefRangeEnd = 169797, XrefRangeStart = 169795, XrefRangeEnd = 169796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_DrawingStrokeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x00178664 File Offset: 0x00176864
		public unsafe Texture DrawingOutputTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_DrawingOutputTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x001786A4 File Offset: 0x001768A4
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x001786E0 File Offset: 0x001768E0
		public unsafe int DrawingPaintedPixelCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_DrawingPaintedPixelCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_set_DrawingPaintedPixelCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x00178720 File Offset: 0x00176920
		public unsafe int RoundedWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169797, XrefRangeEnd = 169798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_RoundedWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06004A53 RID: 19027 RVA: 0x0017875C File Offset: 0x0017695C
		public unsafe int RoundedHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169798, XrefRangeEnd = 169799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_RoundedHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x00178798 File Offset: 0x00176998
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x001787D4 File Offset: 0x001769D4
		public unsafe bool ContainsCartelGraffiti
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_ContainsCartelGraffiti_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_set_ContainsCartelGraffiti_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x00178814 File Offset: 0x00176A14
		public unsafe Vector3 TopRightPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169799, XrefRangeEnd = 169800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_TopRightPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00178850 File Offset: 0x00176A50
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 169801, RefRangeEnd = 169803, XrefRangeStart = 169800, XrefRangeEnd = 169801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0017888C File Offset: 0x00176A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169803, XrefRangeEnd = 169804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x001788C8 File Offset: 0x00176AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169804, XrefRangeEnd = 169806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00178904 File Offset: 0x00176B04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 169817, RefRangeEnd = 169822, XrefRangeStart = 169806, XrefRangeEnd = 169817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeProjector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_ResizeProjector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00178938 File Offset: 0x00176B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169827, RefRangeEnd = 169828, XrefRangeStart = 169822, XrefRangeEnd = 169827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeEdited(bool checkEditor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkEditor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_CanBeEdited_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00178984 File Offset: 0x00176B84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 169828, RefRangeEnd = 169832, XrefRangeStart = 169828, XrefRangeEnd = 169828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_CanUndo_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x001789C0 File Offset: 0x00176BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169832, XrefRangeEnd = 169844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00178A10 File Offset: 0x00176C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169844, XrefRangeEnd = 169848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReplicateTo(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_ReplicateTo_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00178A60 File Offset: 0x00176C60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 169858, RefRangeEnd = 169864, XrefRangeStart = 169848, XrefRangeEnd = 169858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentEditor_Server(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_SetCurrentEditor_Server_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00178AA4 File Offset: 0x00176CA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169903, RefRangeEnd = 169906, XrefRangeStart = 169864, XrefRangeEnd = 169903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentEditor_Client(NetworkConnection conn, NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_SetCurrentEditor_Client_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00178AF8 File Offset: 0x00176CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169906, XrefRangeEnd = 169907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEditingFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00178B34 File Offset: 0x00176D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169907, XrefRangeEnd = 169931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStrokes_Server(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_AddStrokes_Server_Public_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00178B84 File Offset: 0x00176D84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169955, RefRangeEnd = 169958, XrefRangeStart = 169931, XrefRangeEnd = 169955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStrokes_Client(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_AddStrokes_Client_Private_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00178BD4 File Offset: 0x00176DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169958, XrefRangeEnd = 169981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTextureToHistory_Server(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_AddTextureToHistory_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00178C14 File Offset: 0x00176E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170004, RefRangeEnd = 170007, XrefRangeStart = 169981, XrefRangeEnd = 170004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTextureToHistory_Client(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_AddTextureToHistory_Client_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00178C54 File Offset: 0x00176E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170007, XrefRangeEnd = 170009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheDrawing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_CacheDrawing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00178C88 File Offset: 0x00176E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170009, XrefRangeEnd = 170019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintHistoryCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_PrintHistoryCount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00178CBC File Offset: 0x00176EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170019, XrefRangeEnd = 170042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo_Server(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_Undo_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00178CFC File Offset: 0x00176EFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170065, RefRangeEnd = 170068, XrefRangeStart = 170042, XrefRangeEnd = 170065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo_Client(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_Undo_Client_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00178D3C File Offset: 0x00176F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170068, XrefRangeEnd = 170069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CleanGraffiti()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00178D78 File Offset: 0x00176F78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170078, RefRangeEnd = 170082, XrefRangeStart = 170069, XrefRangeEnd = 170078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDrawing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_ClearDrawing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00178DAC File Offset: 0x00176FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170082, XrefRangeEnd = 170083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureDrawingExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_EnsureDrawingExists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00178DE0 File Offset: 0x00176FE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 170108, RefRangeEnd = 170114, XrefRangeStart = 170083, XrefRangeEnd = 170108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewDrawing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_CreateNewDrawing_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00178E14 File Offset: 0x00177014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170114, XrefRangeEnd = 170116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreFromCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RestoreFromCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00178E48 File Offset: 0x00177048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170116, XrefRangeEnd = 170117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ToWorldPosition(UShort2 coordinate, float offset = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coordinate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_ToWorldPosition_Public_Vector3_UShort2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00178EA0 File Offset: 0x001770A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170117, XrefRangeEnd = 170119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawPaintedPixel(PixelData data, bool applyTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00178EF0 File Offset: 0x001770F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 170160, RefRangeEnd = 170165, XrefRangeStart = 170119, XrefRangeEnd = 170160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00178F54 File Offset: 0x00177154
		[CallerCount(0)]
		public unsafe void DrawingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_DrawingChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00178F88 File Offset: 0x00177188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170165, XrefRangeEnd = 170175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGraffitiDrawing GetSerializedDrawing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_GetSerializedDrawing_Public_SerializedGraffitiDrawing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGraffitiDrawing>(intPtr3) : null;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00178FC8 File Offset: 0x001771C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170187, RefRangeEnd = 170188, XrefRangeStart = 170175, XrefRangeEnd = 170187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSerializedDrawing(SerializedGraffitiDrawing serializedDrawing, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedDrawing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_LoadSerializedDrawing_Public_Void_SerializedGraffitiDrawing_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00179018 File Offset: 0x00177218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170188, RefRangeEnd = 170189, XrefRangeStart = 170188, XrefRangeEnd = 170188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillDrawingFit(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_WillDrawingFit_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00179070 File Offset: 0x00177270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170193, RefRangeEnd = 170194, XrefRangeStart = 170189, XrefRangeEnd = 170193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPadding(byte strokeSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strokeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_GetPadding_Public_Static_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x001790B0 File Offset: 0x001772B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170194, XrefRangeEnd = 170195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x001790F8 File Offset: 0x001772F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170195, XrefRangeEnd = 170206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SpraySurfaceData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SpraySurfaceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpraySurfaceData>(intPtr3) : null;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00179144 File Offset: 0x00177344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170206, XrefRangeEnd = 170214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpraySurface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpraySurface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00179180 File Offset: 0x00177380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170288, RefRangeEnd = 170289, XrefRangeStart = 170214, XrefRangeEnd = 170288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x001791BC File Offset: 0x001773BC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x001791F8 File Offset: 0x001773F8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x00179234 File Offset: 0x00177434
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 169858, RefRangeEnd = 169864, XrefRangeStart = 169858, XrefRangeEnd = 169864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_SetCurrentEditor_Server_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x00179278 File Offset: 0x00177478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170289, XrefRangeEnd = 170290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Server_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001792BC File Offset: 0x001774BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170290, XrefRangeEnd = 170293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetCurrentEditor_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Server_SetCurrentEditor_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00179320 File Offset: 0x00177520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170293, XrefRangeEnd = 170303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00179374 File Offset: 0x00177574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170303, XrefRangeEnd = 170304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x001793C8 File Offset: 0x001775C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170304, XrefRangeEnd = 170308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x00179418 File Offset: 0x00177618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170308, XrefRangeEnd = 170318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Target_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x0017946C File Offset: 0x0017766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170318, XrefRangeEnd = 170322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Target_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x001794BC File Offset: 0x001776BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170322, XrefRangeEnd = 170334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_AddStrokes_Server_1511871282_Private_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x0017950C File Offset: 0x0017770C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169955, RefRangeEnd = 169958, XrefRangeStart = 169955, XrefRangeEnd = 169958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___AddStrokes_Server_1511871282_Public_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x0017955C File Offset: 0x0017775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170334, XrefRangeEnd = 170340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddStrokes_Server_1511871282(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Server_AddStrokes_Server_1511871282_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001795C0 File Offset: 0x001777C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170340, XrefRangeEnd = 170352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x00179610 File Offset: 0x00177810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170361, RefRangeEnd = 170364, XrefRangeStart = 170352, XrefRangeEnd = 170361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newStrokes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00179660 File Offset: 0x00177860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170364, XrefRangeEnd = 170370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddStrokes_Client_1511871282(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_AddStrokes_Client_1511871282_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x001796B0 File Offset: 0x001778B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170370, XrefRangeEnd = 170381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddTextureToHistory_Server_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_AddTextureToHistory_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x001796F0 File Offset: 0x001778F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170004, RefRangeEnd = 170007, XrefRangeStart = 170004, XrefRangeEnd = 170007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTextureToHistory_Server_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00179730 File Offset: 0x00177930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170381, XrefRangeEnd = 170386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddTextureToHistory_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Server_AddTextureToHistory_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00179794 File Offset: 0x00177994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170386, XrefRangeEnd = 170397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddTextureToHistory_Client_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_AddTextureToHistory_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x001797D4 File Offset: 0x001779D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170406, RefRangeEnd = 170409, XrefRangeStart = 170397, XrefRangeEnd = 170406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTextureToHistory_Client_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00179814 File Offset: 0x00177A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170409, XrefRangeEnd = 170414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddTextureToHistory_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_AddTextureToHistory_Client_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00179864 File Offset: 0x00177A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170414, XrefRangeEnd = 170425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Undo_Server_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_Undo_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x001798A4 File Offset: 0x00177AA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170065, RefRangeEnd = 170068, XrefRangeStart = 170065, XrefRangeEnd = 170068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Undo_Server_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___Undo_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x001798E4 File Offset: 0x00177AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170425, XrefRangeEnd = 170430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Undo_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Server_Undo_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00179948 File Offset: 0x00177B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170430, XrefRangeEnd = 170441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Undo_Client_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Undo_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00179988 File Offset: 0x00177B88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170449, RefRangeEnd = 170452, XrefRangeStart = 170441, XrefRangeEnd = 170449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Undo_Client_3316948804(int requestID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___Undo_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x001799C8 File Offset: 0x00177BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170452, XrefRangeEnd = 170457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Undo_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Undo_Client_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x00179A18 File Offset: 0x00177C18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 170078, RefRangeEnd = 170082, XrefRangeStart = 170078, XrefRangeEnd = 170082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ClearDrawing_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Server_ClearDrawing_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00179A4C File Offset: 0x00177C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170457, XrefRangeEnd = 170462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearDrawing_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___ClearDrawing_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x00179A80 File Offset: 0x00177C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170462, XrefRangeEnd = 170468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ClearDrawing_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Server_ClearDrawing_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00179AE4 File Offset: 0x00177CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170468, XrefRangeEnd = 170479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Set_4105842735(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Observers_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00179B48 File Offset: 0x00177D48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170484, RefRangeEnd = 170487, XrefRangeStart = 170479, XrefRangeEnd = 170484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Set_4105842735(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcLogic___Set_4105842735_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00179BAC File Offset: 0x00177DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170487, XrefRangeEnd = 170491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Observers_Set_4105842735_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x00179BFC File Offset: 0x00177DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170491, XrefRangeEnd = 170502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Set_4105842735(NetworkConnection conn, Il2CppReferenceArray<SprayStroke> strokes, bool isCartelGraffiti)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(strokes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCartelGraffiti;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcWriter___Target_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00179C60 File Offset: 0x00177E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170502, XrefRangeEnd = 170506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurface.NativeMethodInfoPtr_RpcReader___Target_Set_4105842735_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x00179CB0 File Offset: 0x00177EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170506, XrefRangeEnd = 170507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpraySurface.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x00024040 File Offset: 0x00022240
		public SpraySurface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x00179CEC File Offset: 0x00177EEC
		// (set) Token: 0x06004AA2 RID: 19106 RVA: 0x00024049 File Offset: 0x00022249
		public unsafe static float PIXEL_SIZE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurface.NativeFieldInfoPtr_PIXEL_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurface.NativeFieldInfoPtr_PIXEL_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x00179D08 File Offset: 0x00177F08
		// (set) Token: 0x06004AA4 RID: 19108 RVA: 0x00024057 File Offset: 0x00022257
		public unsafe NetworkObject _CurrentEditor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr__CurrentEditor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr__CurrentEditor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x00179D38 File Offset: 0x00177F38
		// (set) Token: 0x06004AA6 RID: 19110 RVA: 0x00024076 File Offset: 0x00022276
		public unsafe bool _ContainsCartelGraffiti_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr__ContainsCartelGraffiti_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr__ContainsCartelGraffiti_k__BackingField)) = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x00179D60 File Offset: 0x00177F60
		// (set) Token: 0x06004AA8 RID: 19112 RVA: 0x00024091 File Offset: 0x00022291
		public unsafe bool Editable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Editable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Editable)) = value;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x00179D88 File Offset: 0x00177F88
		// (set) Token: 0x06004AAA RID: 19114 RVA: 0x000240AC File Offset: 0x000222AC
		public unsafe int Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004AAB RID: 19115 RVA: 0x00179DB0 File Offset: 0x00177FB0
		// (set) Token: 0x06004AAC RID: 19116 RVA: 0x000240C7 File Offset: 0x000222C7
		public unsafe int Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004AAD RID: 19117 RVA: 0x00179DD8 File Offset: 0x00177FD8
		// (set) Token: 0x06004AAE RID: 19118 RVA: 0x000240E2 File Offset: 0x000222E2
		public unsafe AnimationCurve FalloffCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_FalloffCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_FalloffCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004AAF RID: 19119 RVA: 0x00179E08 File Offset: 0x00178008
		// (set) Token: 0x06004AB0 RID: 19120 RVA: 0x00024101 File Offset: 0x00022301
		public unsafe bool IsVandalismSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_IsVandalismSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_IsVandalismSurface)) = value;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x00179E30 File Offset: 0x00178030
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x0002411C File Offset: 0x0002231C
		public unsafe Transform BottomLeftPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_BottomLeftPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_BottomLeftPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x00179E60 File Offset: 0x00178060
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x0002413B File Offset: 0x0002233B
		public unsafe DecalProjector Projector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Projector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_Projector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06004AB5 RID: 19125 RVA: 0x00179E90 File Offset: 0x00178090
		// (set) Token: 0x06004AB6 RID: 19126 RVA: 0x0002415A File Offset: 0x0002235A
		public unsafe Drawing drawing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_drawing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Drawing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_drawing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x00179EC0 File Offset: 0x001780C0
		// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x00024179 File Offset: 0x00022379
		public unsafe Drawing cachedDrawing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_cachedDrawing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Drawing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_cachedDrawing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004AB9 RID: 19129 RVA: 0x00179EF0 File Offset: 0x001780F0
		// (set) Token: 0x06004ABA RID: 19130 RVA: 0x00024198 File Offset: 0x00022398
		public unsafe Action onDrawingChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_onDrawingChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_onDrawingChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004ABB RID: 19131 RVA: 0x00179F20 File Offset: 0x00178120
		// (set) Token: 0x06004ABC RID: 19132 RVA: 0x000241B7 File Offset: 0x000223B7
		public unsafe List<int> pastRequestIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_pastRequestIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_pastRequestIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x00179F50 File Offset: 0x00178150
		// (set) Token: 0x06004ABE RID: 19134 RVA: 0x000241D6 File Offset: 0x000223D6
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004ABF RID: 19135 RVA: 0x00179F78 File Offset: 0x00178178
		// (set) Token: 0x06004AC0 RID: 19136 RVA: 0x000241F1 File Offset: 0x000223F1
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurface.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr_PIXEL_SIZE;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEditor_k__BackingField;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr__ContainsCartelGraffiti_k__BackingField;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeFieldInfoPtr_Editable;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeFieldInfoPtr_FalloffCurve;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeFieldInfoPtr_IsVandalismSurface;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeFieldInfoPtr_BottomLeftPoint;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeFieldInfoPtr_Projector;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeFieldInfoPtr_drawing;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeFieldInfoPtr_cachedDrawing;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeFieldInfoPtr_onDrawingChanged;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeFieldInfoPtr_pastRequestIDs;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEditor_Public_get_NetworkObject_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEditor_Private_set_Void_NetworkObject_0;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawingStrokeCount_Public_get_Int32_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawingOutputTexture_Public_get_Texture_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_get_DrawingPaintedPixelCount_Public_get_Int32_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr_set_DrawingPaintedPixelCount_Public_set_Void_Int32_0;

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundedWidth_Public_get_Int32_0;

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundedHeight_Public_get_Int32_0;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsCartelGraffiti_Public_get_Boolean_0;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeMethodInfoPtr_set_ContainsCartelGraffiti_Public_set_Void_Boolean_0;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeMethodInfoPtr_get_TopRightPoint_Public_get_Vector3_0;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeMethodInfoPtr_ResizeProjector_Private_Void_0;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeMethodInfoPtr_CanBeEdited_Public_Boolean_Boolean_0;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeMethodInfoPtr_CanUndo_Public_Boolean_0;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateTo_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentEditor_Server_Public_Void_NetworkObject_0;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentEditor_Client_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr_OnEditingFinished_Public_Virtual_New_Void_0;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeMethodInfoPtr_AddStrokes_Server_Public_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr_AddStrokes_Client_Private_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeMethodInfoPtr_AddTextureToHistory_Server_Public_Void_Int32_0;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr_AddTextureToHistory_Client_Private_Void_Int32_0;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeMethodInfoPtr_CacheDrawing_Public_Void_0;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr_PrintHistoryCount_Public_Void_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Server_Public_Void_Int32_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Client_Private_Void_Int32_0;

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeMethodInfoPtr_CleanGraffiti_Public_Virtual_New_Void_0;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr_ClearDrawing_Public_Void_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDrawingExists_Public_Void_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewDrawing_Protected_Void_0;

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeMethodInfoPtr_RestoreFromCache_Public_Void_0;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_ToWorldPosition_Public_Vector3_UShort2_Single_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_DrawPaintedPixel_Public_Void_PixelData_Boolean_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0;

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_DrawingChanged_Private_Void_0;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializedDrawing_Public_SerializedGraffitiDrawing_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_LoadSerializedDrawing_Public_Void_SerializedGraffitiDrawing_Boolean_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_WillDrawingFit_Public_Boolean_Int32_Int32_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Int32_Byte_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SpraySurfaceData_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetCurrentEditor_Server_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Server_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetCurrentEditor_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetCurrentEditor_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetCurrentEditor_Client_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddStrokes_Server_1511871282_Private_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddStrokes_Server_1511871282_Public_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddStrokes_Server_1511871282_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddStrokes_Client_1511871282_Private_Void_List_1_SprayStroke_Int32_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddStrokes_Client_1511871282_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddTextureToHistory_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddTextureToHistory_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddTextureToHistory_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTextureToHistory_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddTextureToHistory_Client_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Undo_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Undo_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Undo_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Undo_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Undo_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Undo_Client_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ClearDrawing_2166136261_Private_Void_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearDrawing_2166136261_Public_Void_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ClearDrawing_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Set_4105842735_Public_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Set_4105842735_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Set_4105842735_Private_Void_NetworkConnection_Il2CppReferenceArray_1_SprayStroke_Boolean_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Set_4105842735_Private_Void_PooledReader_Channel_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
