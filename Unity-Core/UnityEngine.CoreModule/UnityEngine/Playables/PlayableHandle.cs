using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200025C RID: 604
	[StructLayout(2)]
	public struct PlayableHandle
	{
		// Token: 0x060029E9 RID: 10729 RVA: 0x000A3560 File Offset: 0x000A1760
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableHandle()
		{
			Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
			PlayableHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Handle");
			PlayableHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Version");
			PlayableHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Null");
			PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667770);
			PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667771);
			PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667772);
			PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667773);
			PlayableHandle.NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667774);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667775);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667776);
			PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667777);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667778);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667779);
			PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667780);
			PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667781);
			PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667782);
			PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667783);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667784);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667785);
			PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667786);
			PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667787);
			PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667788);
			PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667789);
			PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667790);
			PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667791);
			PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667792);
			PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667793);
			PlayableHandle.NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667794);
			PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667795);
			PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667796);
			PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667797);
			PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667798);
			PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667799);
			PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667800);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667801);
			PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667802);
			PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667803);
			PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667804);
			PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667805);
			PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667806);
			PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667807);
			PlayableHandle.NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667808);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667809);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667810);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667812);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667813);
			PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667814);
			PlayableHandle.NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667815);
			PlayableHandle.NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667816);
			PlayableHandle.NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667817);
			PlayableHandle.NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667818);
			PlayableHandle.NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667819);
			PlayableHandle.NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667820);
			PlayableHandle.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667821);
			PlayableHandle.NativeMethodInfoPtr_SetDone_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667822);
			PlayableHandle.NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667823);
			PlayableHandle.NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667824);
			PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667825);
			PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667826);
			PlayableHandle.NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667827);
			PlayableHandle.NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667828);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667829);
			PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667830);
			PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667831);
			PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667832);
			PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667833);
			PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667834);
			PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667835);
			PlayableHandle.NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667836);
			PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667837);
			PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100667838);
			PlayableHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsNull_Injected");
			PlayableHandle.GetJobType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobType_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobType_Injected");
			PlayableHandle.CanChangeInputs_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanChangeInputs_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs_Injected");
			PlayableHandle.CanSetWeights_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanSetWeights_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights_Injected");
			PlayableHandle.CanDestroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanDestroy_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy_Injected");
			PlayableHandle.GetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetSpeed_Injected");
			PlayableHandle.GetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime_Injected");
			PlayableHandle.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputCount_Injected");
			PlayableHandle.SetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount_Injected");
			PlayableHandle.SetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay_Injected");
			PlayableHandle.GetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay_Injected");
			PlayableHandle.IsDelayed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDelayed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed_Injected");
			PlayableHandle.SetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime_Injected");
			PlayableHandle.GetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime_Injected");
			PlayableHandle.GetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode_Injected");
			PlayableHandle.GetJobData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobData_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobData_Injected");
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000A3C0C File Offset: 0x000A1E0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293137, RefRangeEnd = 1293140, XrefRangeStart = 1293126, XrefRangeEnd = 1293137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetObject<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_GetObject_Internal_T_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000A3C3C File Offset: 0x000A1E3C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1293150, RefRangeEnd = 1293171, XrefRangeStart = 1293140, XrefRangeEnd = 1293150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060029EC RID: 10732 RVA: 0x000A3C6C File Offset: 0x000A1E6C
		public unsafe static PlayableHandle Null
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 1293175, RefRangeEnd = 1293207, XrefRangeStart = 1293171, XrefRangeEnd = 1293175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000A3C9C File Offset: 0x000A1E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293215, RefRangeEnd = 1293216, XrefRangeStart = 1293207, XrefRangeEnd = 1293215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable GetInput(int inputPort)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000A3CDC File Offset: 0x000A1EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293224, RefRangeEnd = 1293225, XrefRangeStart = 1293216, XrefRangeEnd = 1293224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable GetOutput(int outputPort)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000A3D1C File Offset: 0x000A1F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293232, RefRangeEnd = 1293233, XrefRangeStart = 1293225, XrefRangeEnd = 1293232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetInputWeight(int inputIndex, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x000A3D68 File Offset: 0x000A1F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293240, RefRangeEnd = 1293241, XrefRangeStart = 1293233, XrefRangeEnd = 1293240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInputWeight(int inputIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000A3DA8 File Offset: 0x000A1FA8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1293246, RefRangeEnd = 1293256, XrefRangeStart = 1293241, XrefRangeEnd = 1293246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000A3DF4 File Offset: 0x000A1FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293256, XrefRangeEnd = 1293265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x000A3E38 File Offset: 0x000A2038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293265, XrefRangeEnd = 1293270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableHandle other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000A3E78 File Offset: 0x000A2078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293270, XrefRangeEnd = 1293272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000A3EA8 File Offset: 0x000A20A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293272, XrefRangeEnd = 1293273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000A3EF4 File Offset: 0x000A20F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293273, XrefRangeEnd = 1293277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckInputBounds(int inputIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000A3F34 File Offset: 0x000A2134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293281, RefRangeEnd = 1293284, XrefRangeStart = 1293277, XrefRangeEnd = 1293281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptAny;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000A3F80 File Offset: 0x000A2180
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1293289, RefRangeEnd = 1293314, XrefRangeStart = 1293284, XrefRangeEnd = 1293289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000A3FB0 File Offset: 0x000A21B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293319, RefRangeEnd = 1293321, XrefRangeStart = 1293314, XrefRangeEnd = 1293319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000A3FE4 File Offset: 0x000A21E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293326, RefRangeEnd = 1293329, XrefRangeStart = 1293321, XrefRangeEnd = 1293326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScriptInstance(Object scriptInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000A401C File Offset: 0x000A221C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293334, RefRangeEnd = 1293335, XrefRangeStart = 1293329, XrefRangeEnd = 1293334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayState GetPlayState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000A404C File Offset: 0x000A224C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293340, RefRangeEnd = 1293342, XrefRangeStart = 1293335, XrefRangeEnd = 1293340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Play_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000A4074 File Offset: 0x000A2274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293347, RefRangeEnd = 1293348, XrefRangeStart = 1293342, XrefRangeEnd = 1293347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Pause_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000A409C File Offset: 0x000A229C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293353, RefRangeEnd = 1293354, XrefRangeStart = 1293348, XrefRangeEnd = 1293353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpeed(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x000A40D0 File Offset: 0x000A22D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293359, RefRangeEnd = 1293360, XrefRangeStart = 1293354, XrefRangeEnd = 1293359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTime_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x000A4100 File Offset: 0x000A2300
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293365, RefRangeEnd = 1293367, XrefRangeStart = 1293360, XrefRangeEnd = 1293365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTime_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000A4134 File Offset: 0x000A2334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293372, RefRangeEnd = 1293373, XrefRangeStart = 1293367, XrefRangeEnd = 1293372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsDone_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000A4164 File Offset: 0x000A2364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293378, RefRangeEnd = 1293380, XrefRangeStart = 1293373, XrefRangeEnd = 1293378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDone(bool value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000A4198 File Offset: 0x000A2398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293385, RefRangeEnd = 1293387, XrefRangeStart = 1293380, XrefRangeEnd = 1293385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetDuration()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetDuration_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000A41C8 File Offset: 0x000A23C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293392, RefRangeEnd = 1293395, XrefRangeStart = 1293387, XrefRangeEnd = 1293392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDuration(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000A41FC File Offset: 0x000A23FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293400, RefRangeEnd = 1293401, XrefRangeStart = 1293395, XrefRangeEnd = 1293400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropagateSetTime(bool value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000A4230 File Offset: 0x000A2430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293406, RefRangeEnd = 1293407, XrefRangeStart = 1293401, XrefRangeEnd = 1293406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableGraph GetGraph()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000A4260 File Offset: 0x000A2460
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1293412, RefRangeEnd = 1293416, XrefRangeStart = 1293407, XrefRangeEnd = 1293412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInputCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputCount_Internal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000A4290 File Offset: 0x000A2490
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1293421, RefRangeEnd = 1293435, XrefRangeStart = 1293416, XrefRangeEnd = 1293421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputCount(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000A42C4 File Offset: 0x000A24C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293440, RefRangeEnd = 1293441, XrefRangeStart = 1293435, XrefRangeEnd = 1293440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputWeight(PlayableHandle input, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000A4304 File Offset: 0x000A2504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293446, RefRangeEnd = 1293447, XrefRangeStart = 1293441, XrefRangeEnd = 1293446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetPreviousTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000A4334 File Offset: 0x000A2534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293454, RefRangeEnd = 1293455, XrefRangeStart = 1293447, XrefRangeEnd = 1293454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTraversalMode(PlayableTraversalMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000A4368 File Offset: 0x000A2568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293460, RefRangeEnd = 1293461, XrefRangeStart = 1293455, XrefRangeEnd = 1293460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectorWrapMode GetTimeWrapMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000A4398 File Offset: 0x000A2598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293466, RefRangeEnd = 1293467, XrefRangeStart = 1293461, XrefRangeEnd = 1293466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeWrapMode(DirectorWrapMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000A43CC File Offset: 0x000A25CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293472, RefRangeEnd = 1293473, XrefRangeStart = 1293467, XrefRangeEnd = 1293472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetScriptInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Private_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000A4400 File Offset: 0x000A2600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293473, XrefRangeEnd = 1293478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetInputHandle(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000A4440 File Offset: 0x000A2640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293478, XrefRangeEnd = 1293483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetOutputHandle(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000A4480 File Offset: 0x000A2680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293483, XrefRangeEnd = 1293488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputWeightFromIndex(int index, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000A44C0 File Offset: 0x000A26C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293488, XrefRangeEnd = 1293493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetInputWeightFromIndex(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000A4500 File Offset: 0x000A2700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293493, XrefRangeEnd = 1293495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000A4540 File Offset: 0x000A2740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293495, XrefRangeEnd = 1293497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000A4580 File Offset: 0x000A2780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293497, XrefRangeEnd = 1293499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, Object scriptInstance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scriptInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000A45C4 File Offset: 0x000A27C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293499, XrefRangeEnd = 1293501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000A4604 File Offset: 0x000A2804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293501, XrefRangeEnd = 1293503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000A4638 File Offset: 0x000A2838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293503, XrefRangeEnd = 1293505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000A466C File Offset: 0x000A286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293505, XrefRangeEnd = 1293507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000A46AC File Offset: 0x000A28AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293507, XrefRangeEnd = 1293509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetTime_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000A46EC File Offset: 0x000A28EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293509, XrefRangeEnd = 1293511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTime_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000A472C File Offset: 0x000A292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293511, XrefRangeEnd = 1293513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000A476C File Offset: 0x000A296C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293513, XrefRangeEnd = 1293515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDone_Injected(ref PlayableHandle _unity_self, bool value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDone_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000A47AC File Offset: 0x000A29AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293515, XrefRangeEnd = 1293517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDuration_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000A47EC File Offset: 0x000A29EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293517, XrefRangeEnd = 1293519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDuration_Injected(ref PlayableHandle _unity_self, double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000A482C File Offset: 0x000A2A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293519, XrefRangeEnd = 1293521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000A486C File Offset: 0x000A2A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293521, XrefRangeEnd = 1293523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000A48AC File Offset: 0x000A2AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293523, XrefRangeEnd = 1293525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInputCount_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000A48EC File Offset: 0x000A2AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293525, XrefRangeEnd = 1293527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000A492C File Offset: 0x000A2B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293527, XrefRangeEnd = 1293529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &input;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000A497C File Offset: 0x000A2B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293529, XrefRangeEnd = 1293531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetPreviousTime_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000A49BC File Offset: 0x000A2BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293531, XrefRangeEnd = 1293533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000A49FC File Offset: 0x000A2BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293533, XrefRangeEnd = 1293535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000A4A3C File Offset: 0x000A2C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293535, XrefRangeEnd = 1293537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000A4A7C File Offset: 0x000A2C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293537, XrefRangeEnd = 1293539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetScriptInstance_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000A4ABC File Offset: 0x000A2CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293539, XrefRangeEnd = 1293541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000A4B0C File Offset: 0x000A2D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293541, XrefRangeEnd = 1293543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000A4B5C File Offset: 0x000A2D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293543, XrefRangeEnd = 1293545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000A4BAC File Offset: 0x000A2DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293545, XrefRangeEnd = 1293547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00012B27 File Offset: 0x00010D27
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000A4BF8 File Offset: 0x000A2DF8
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00012B39 File Offset: 0x00010D39
		public unsafe static PlayableHandle m_Null
		{
			get
			{
				PlayableHandle result;
				IL2CPP.il2cpp_field_static_get_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000A4C14 File Offset: 0x000A2E14
		public void Destroy()
		{
			this.GetGraph().DestroyPlayable<Playable>(new Playable(this));
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000A4C3C File Offset: 0x000A2E3C
		public static bool operator !=(PlayableHandle x, PlayableHandle y)
		{
			return !PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00012B47 File Offset: 0x00010D47
		public bool IsNull()
		{
			return PlayableHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00012B4F File Offset: 0x00010D4F
		public Type GetJobType()
		{
			return PlayableHandle.GetJobType_Injected(ref this);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00012B57 File Offset: 0x00010D57
		public bool CanChangeInputs()
		{
			return PlayableHandle.CanChangeInputs_Injected(ref this);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00012B5F File Offset: 0x00010D5F
		public bool CanSetWeights()
		{
			return PlayableHandle.CanSetWeights_Injected(ref this);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00012B67 File Offset: 0x00010D67
		public bool CanDestroy()
		{
			return PlayableHandle.CanDestroy_Injected(ref this);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00012B6F File Offset: 0x00010D6F
		public double GetSpeed()
		{
			return PlayableHandle.GetSpeed_Injected(ref this);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00012B77 File Offset: 0x00010D77
		public bool GetPropagateSetTime()
		{
			return PlayableHandle.GetPropagateSetTime_Injected(ref this);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00012B7F File Offset: 0x00010D7F
		public int GetOutputCount()
		{
			return PlayableHandle.GetOutputCount_Injected(ref this);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00012B87 File Offset: 0x00010D87
		public void SetOutputCount(int value)
		{
			PlayableHandle.SetOutputCount_Injected(ref this, value);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00012B90 File Offset: 0x00010D90
		public void SetDelay(double delay)
		{
			PlayableHandle.SetDelay_Injected(ref this, delay);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00012B99 File Offset: 0x00010D99
		public double GetDelay()
		{
			return PlayableHandle.GetDelay_Injected(ref this);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00012BA1 File Offset: 0x00010DA1
		public bool IsDelayed()
		{
			return PlayableHandle.IsDelayed_Injected(ref this);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00012BA9 File Offset: 0x00010DA9
		public void SetLeadTime(float value)
		{
			PlayableHandle.SetLeadTime_Injected(ref this, value);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00012BB2 File Offset: 0x00010DB2
		public float GetLeadTime()
		{
			return PlayableHandle.GetLeadTime_Injected(ref this);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00012BBA File Offset: 0x00010DBA
		public PlayableTraversalMode GetTraversalMode()
		{
			return PlayableHandle.GetTraversalMode_Injected(ref this);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00012BC2 File Offset: 0x00010DC2
		public IntPtr GetJobData()
		{
			return PlayableHandle.GetJobData_Injected(ref this);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00012BCA File Offset: 0x00010DCA
		public static bool IsNull_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000A4C58 File Offset: 0x000A2E58
		public static Type GetJobType_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetJobType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00012BD7 File Offset: 0x00010DD7
		public static bool CanChangeInputs_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanChangeInputs_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00012BE4 File Offset: 0x00010DE4
		public static bool CanSetWeights_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanSetWeights_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00012BF1 File Offset: 0x00010DF1
		public static bool CanDestroy_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanDestroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00012BFE File Offset: 0x00010DFE
		public static double GetSpeed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetSpeed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00012C0B File Offset: 0x00010E0B
		public static bool GetPropagateSetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPropagateSetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00012C18 File Offset: 0x00010E18
		public static int GetOutputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00012C25 File Offset: 0x00010E25
		public static void SetOutputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetOutputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00012C33 File Offset: 0x00010E33
		public static void SetDelay_Injected(ref PlayableHandle _unity_self, double delay)
		{
			PlayableHandle.SetDelay_InjectedDelegateField(ref _unity_self, delay);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00012C41 File Offset: 0x00010E41
		public static double GetDelay_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDelay_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00012C4E File Offset: 0x00010E4E
		public static bool IsDelayed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDelayed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00012C5B File Offset: 0x00010E5B
		public static void SetLeadTime_Injected(ref PlayableHandle _unity_self, float value)
		{
			PlayableHandle.SetLeadTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00012C69 File Offset: 0x00010E69
		public static float GetLeadTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetLeadTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00012C76 File Offset: 0x00010E76
		public static PlayableTraversalMode GetTraversalMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTraversalMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00012C83 File Offset: 0x00010E83
		public static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetJobData_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Internal_T_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Internal_Playable_Int32_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Internal_Playable_Int32_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Boolean_Int32_Single_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeight_Internal_Single_Int32_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputBounds_Internal_Boolean_Int32_Boolean_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptInstance_Internal_Void_Object_0;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Internal_PlayState_0;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeMethodInfoPtr_Play_Internal_Void_0;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Internal_Void_0;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Internal_Void_Double_0;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Internal_Double_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Internal_Void_Double_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Internal_Boolean_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_SetDone_Internal_Void_Boolean_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Internal_Double_0;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Internal_Void_Double_0;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Internal_Void_Boolean_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Internal_PlayableGraph_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Internal_Int32_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Internal_Void_Int32_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Internal_Void_PlayableHandle_Single_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Internal_Double_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Internal_Void_PlayableTraversalMode_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_DirectorWrapMode_0;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Void_DirectorWrapMode_0;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptInstance_Private_Object_0;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_GetInputHandle_Private_PlayableHandle_Int32_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputHandle_Private_PlayableHandle_Int32_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Private_Void_Int32_Single_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Private_Single_Int32_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_SetScriptInstance_Injected_Private_Static_Void_byref_PlayableHandle_Object_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Injected_Private_Static_PlayState_byref_PlayableHandle_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_Play_Injected_Private_Static_Void_byref_PlayableHandle_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Injected_Private_Static_Void_byref_PlayableHandle_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_SetDone_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Injected_Private_Static_Void_byref_PlayableHandle_Double_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Injected_Private_Static_Void_byref_PlayableHandle_Boolean_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableGraph_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Injected_Private_Static_Int32_byref_PlayableHandle_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Injected_Private_Static_Void_byref_PlayableHandle_Int32_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Injected_Private_Static_Void_byref_PlayableHandle_byref_PlayableHandle_Single_0;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Injected_Private_Static_Double_byref_PlayableHandle_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Injected_Private_Static_Void_byref_PlayableHandle_PlayableTraversalMode_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Injected_Private_Static_DirectorWrapMode_byref_PlayableHandle_0;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Injected_Private_Static_Void_byref_PlayableHandle_DirectorWrapMode_0;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeMethodInfoPtr_GetScriptInstance_Injected_Private_Static_Object_byref_PlayableHandle_0;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr_GetInputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputHandle_Injected_Private_Static_Void_byref_PlayableHandle_Int32_byref_PlayableHandle_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeightFromIndex_Injected_Private_Static_Void_byref_PlayableHandle_Int32_Single_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeightFromIndex_Injected_Private_Static_Single_byref_PlayableHandle_Int32_0;

		// Token: 0x040023C0 RID: 9152
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x040023C1 RID: 9153
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x040023C2 RID: 9154
		private static readonly PlayableHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x040023C3 RID: 9155
		private static readonly PlayableHandle.GetJobType_InjectedDelegate GetJobType_InjectedDelegateField;

		// Token: 0x040023C4 RID: 9156
		private static readonly PlayableHandle.CanChangeInputs_InjectedDelegate CanChangeInputs_InjectedDelegateField;

		// Token: 0x040023C5 RID: 9157
		private static readonly PlayableHandle.CanSetWeights_InjectedDelegate CanSetWeights_InjectedDelegateField;

		// Token: 0x040023C6 RID: 9158
		private static readonly PlayableHandle.CanDestroy_InjectedDelegate CanDestroy_InjectedDelegateField;

		// Token: 0x040023C7 RID: 9159
		private static readonly PlayableHandle.GetSpeed_InjectedDelegate GetSpeed_InjectedDelegateField;

		// Token: 0x040023C8 RID: 9160
		private static readonly PlayableHandle.GetPropagateSetTime_InjectedDelegate GetPropagateSetTime_InjectedDelegateField;

		// Token: 0x040023C9 RID: 9161
		private static readonly PlayableHandle.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x040023CA RID: 9162
		private static readonly PlayableHandle.SetOutputCount_InjectedDelegate SetOutputCount_InjectedDelegateField;

		// Token: 0x040023CB RID: 9163
		private static readonly PlayableHandle.SetDelay_InjectedDelegate SetDelay_InjectedDelegateField;

		// Token: 0x040023CC RID: 9164
		private static readonly PlayableHandle.GetDelay_InjectedDelegate GetDelay_InjectedDelegateField;

		// Token: 0x040023CD RID: 9165
		private static readonly PlayableHandle.IsDelayed_InjectedDelegate IsDelayed_InjectedDelegateField;

		// Token: 0x040023CE RID: 9166
		private static readonly PlayableHandle.SetLeadTime_InjectedDelegate SetLeadTime_InjectedDelegateField;

		// Token: 0x040023CF RID: 9167
		private static readonly PlayableHandle.GetLeadTime_InjectedDelegate GetLeadTime_InjectedDelegateField;

		// Token: 0x040023D0 RID: 9168
		private static readonly PlayableHandle.GetTraversalMode_InjectedDelegate GetTraversalMode_InjectedDelegateField;

		// Token: 0x040023D1 RID: 9169
		private static readonly PlayableHandle.GetJobData_InjectedDelegate GetJobData_InjectedDelegateField;

		// Token: 0x02000BC4 RID: 3012
		private sealed class MethodInfoStoreGeneric_GetObject_Internal_T_0<T>
		{
			// Token: 0x04002C14 RID: 11284
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_GetObject_Internal_T_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BC5 RID: 3013
		private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04002C15 RID: 11285
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BC6 RID: 3014
		// (Invoke) Token: 0x0600405B RID: 16475
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BC7 RID: 3015
		// (Invoke) Token: 0x0600405D RID: 16477
		private delegate IntPtr GetJobType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BC8 RID: 3016
		// (Invoke) Token: 0x0600405F RID: 16479
		private delegate bool CanChangeInputs_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BC9 RID: 3017
		// (Invoke) Token: 0x06004061 RID: 16481
		private delegate bool CanSetWeights_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BCA RID: 3018
		// (Invoke) Token: 0x06004063 RID: 16483
		private delegate bool CanDestroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BCB RID: 3019
		// (Invoke) Token: 0x06004065 RID: 16485
		private delegate double GetSpeed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BCC RID: 3020
		// (Invoke) Token: 0x06004067 RID: 16487
		private delegate bool GetPropagateSetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BCD RID: 3021
		// (Invoke) Token: 0x06004069 RID: 16489
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BCE RID: 3022
		// (Invoke) Token: 0x0600406B RID: 16491
		private delegate void SetOutputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x02000BCF RID: 3023
		// (Invoke) Token: 0x0600406D RID: 16493
		private delegate void SetDelay_InjectedDelegate(IntPtr _unity_self, double delay);

		// Token: 0x02000BD0 RID: 3024
		// (Invoke) Token: 0x0600406F RID: 16495
		private delegate double GetDelay_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BD1 RID: 3025
		// (Invoke) Token: 0x06004071 RID: 16497
		private delegate bool IsDelayed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BD2 RID: 3026
		// (Invoke) Token: 0x06004073 RID: 16499
		private delegate void SetLeadTime_InjectedDelegate(IntPtr _unity_self, float value);

		// Token: 0x02000BD3 RID: 3027
		// (Invoke) Token: 0x06004075 RID: 16501
		private delegate float GetLeadTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BD4 RID: 3028
		// (Invoke) Token: 0x06004077 RID: 16503
		private delegate PlayableTraversalMode GetTraversalMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BD5 RID: 3029
		// (Invoke) Token: 0x06004079 RID: 16505
		private delegate IntPtr GetJobData_InjectedDelegate(IntPtr _unity_self);
	}
}
