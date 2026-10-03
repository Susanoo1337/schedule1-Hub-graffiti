using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200025A RID: 602
	[StructLayout(2)]
	public struct PlayableGraph
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x000A28F8 File Offset: 0x000A0AF8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableGraph()
		{
			Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableGraph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr);
			PlayableGraph.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Handle");
			PlayableGraph.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, "m_Version");
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667741);
			PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667742);
			PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667743);
			PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667744);
			PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667745);
			PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667746);
			PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667747);
			PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667748);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667749);
			PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667750);
			PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667751);
			PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667752);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667753);
			PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667754);
			PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667755);
			PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667756);
			PlayableGraph.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667757);
			PlayableGraph.NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667758);
			PlayableGraph.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_byref_PlayableGraph_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667759);
			PlayableGraph.NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667760);
			PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667761);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667762);
			PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667763);
			PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667764);
			PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667765);
			PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667766);
			PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Injected_Private_Static_Boolean_byref_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667767);
			PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667768);
			PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, 100667769);
			PlayableGraph.Create_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Create_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Create_Injected");
			PlayableGraph.Destroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Destroy_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Destroy_Injected");
			PlayableGraph.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::IsDone_Injected");
			PlayableGraph.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Play_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Play_Injected");
			PlayableGraph.Stop_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.Stop_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::Stop_Injected");
			PlayableGraph.GetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetTimeUpdateMode_Injected");
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetTimeUpdateMode_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetTimeUpdateMode_Injected");
			PlayableGraph.SetResolver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.SetResolver_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::SetResolver_Injected");
			PlayableGraph.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCount_Injected");
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyOutputInternal_Injected");
			PlayableGraph.EnableMatchFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.EnableMatchFrameRate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::EnableMatchFrameRate_Injected");
			PlayableGraph.DisableMatchFrameRate_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisableMatchFrameRate_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisableMatchFrameRate_Injected");
			PlayableGraph.GetOutputInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputInternal_Injected");
			PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputCountByTypeInternal_Injected");
			PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.GetOutputByTypeInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::GetOutputByTypeInternal_Injected");
			PlayableGraph.DisconnectInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DisconnectInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DisconnectInternal_Injected");
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroyPlayableInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroyPlayableInternal_Injected");
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField = IL2CPP.ResolveICall<PlayableGraph.DestroySubgraphInternal_InjectedDelegate>("UnityEngine.Playables.PlayableGraph::DestroySubgraphInternal_Injected");
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000A2CA4 File Offset: 0x000A0EA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293055, RefRangeEnd = 1293057, XrefRangeStart = 1293053, XrefRangeEnd = 1293055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable GetRootPlayable(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x000A2CE4 File Offset: 0x000A0EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293066, RefRangeEnd = 1293067, XrefRangeStart = 1293057, XrefRangeEnd = 1293066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) where U : new() where V : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = source;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref source;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = destination;
				if (!(v is string))
				{
					ref V ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
				}
			}
			else
			{
				ptr7 = ref destination;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x000A2DEC File Offset: 0x000A0FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293069, RefRangeEnd = 1293070, XrefRangeStart = 1293067, XrefRangeEnd = 1293069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000A2E14 File Offset: 0x000A1014
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1293072, RefRangeEnd = 1293077, XrefRangeStart = 1293070, XrefRangeEnd = 1293072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000A2E44 File Offset: 0x000A1044
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1293079, RefRangeEnd = 1293085, XrefRangeStart = 1293077, XrefRangeEnd = 1293079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlaying()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000A2E74 File Offset: 0x000A1074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293085, XrefRangeEnd = 1293087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Evaluate_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000A2EA8 File Offset: 0x000A10A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293089, RefRangeEnd = 1293090, XrefRangeStart = 1293087, XrefRangeEnd = 1293089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IExposedPropertyTable GetResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr3) : null;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000A2EDC File Offset: 0x000A10DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293092, RefRangeEnd = 1293093, XrefRangeStart = 1293090, XrefRangeEnd = 1293092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayableCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000A2F0C File Offset: 0x000A110C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293095, RefRangeEnd = 1293097, XrefRangeStart = 1293093, XrefRangeEnd = 1293095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRootPlayableCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000A2F3C File Offset: 0x000A113C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293099, RefRangeEnd = 1293100, XrefRangeStart = 1293097, XrefRangeEnd = 1293099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizeEvaluation(PlayableGraph playable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000A2F70 File Offset: 0x000A1170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293102, RefRangeEnd = 1293103, XrefRangeStart = 1293100, XrefRangeEnd = 1293102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle CreatePlayableHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x000A2FA0 File Offset: 0x000A11A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293103, XrefRangeEnd = 1293105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000A2FF0 File Offset: 0x000A11F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293105, XrefRangeEnd = 1293107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetRootPlayableInternal(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000A3030 File Offset: 0x000A1230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293109, RefRangeEnd = 1293111, XrefRangeStart = 1293107, XrefRangeEnd = 1293109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchFrameRateEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000A3060 File Offset: 0x000A1260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293111, XrefRangeEnd = 1293113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameRate GetFrameRate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000A3090 File Offset: 0x000A1290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293115, RefRangeEnd = 1293116, XrefRangeStart = 1293113, XrefRangeEnd = 1293115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000A30F8 File Offset: 0x000A12F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1293072, RefRangeEnd = 1293077, XrefRangeStart = 1293072, XrefRangeEnd = 1293077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000A3138 File Offset: 0x000A1338
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1293079, RefRangeEnd = 1293085, XrefRangeStart = 1293079, XrefRangeEnd = 1293085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPlaying_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000A3178 File Offset: 0x000A1378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_byref_PlayableGraph_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000A31B8 File Offset: 0x000A13B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293089, RefRangeEnd = 1293090, XrefRangeStart = 1293089, XrefRangeEnd = 1293090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IExposedPropertyTable>(intPtr3) : null;
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000A31F8 File Offset: 0x000A13F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293092, RefRangeEnd = 1293093, XrefRangeStart = 1293092, XrefRangeEnd = 1293093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000A3238 File Offset: 0x000A1438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293095, RefRangeEnd = 1293097, XrefRangeStart = 1293095, XrefRangeEnd = 1293097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000A3278 File Offset: 0x000A1478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293116, XrefRangeEnd = 1293118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SynchronizeEvaluation_Injected(ref PlayableGraph _unity_self, ref PlayableGraph playable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &playable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000A32B8 File Offset: 0x000A14B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293118, XrefRangeEnd = 1293120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000A32F8 File Offset: 0x000A14F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000A3358 File Offset: 0x000A1558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293120, XrefRangeEnd = 1293122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000A33A8 File Offset: 0x000A15A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293109, RefRangeEnd = 1293111, XrefRangeStart = 1293109, XrefRangeEnd = 1293111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatchFrameRateEnabled_Injected(ref PlayableGraph _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_IsMatchFrameRateEnabled_Injected_Private_Static_Boolean_byref_PlayableGraph_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000A33E8 File Offset: 0x000A15E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293122, XrefRangeEnd = 1293124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFrameRate_Injected(ref PlayableGraph _unity_self, out FrameRate ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000A3428 File Offset: 0x000A1628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293124, XrefRangeEnd = 1293126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &source;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceOutputPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destination;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationInputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableGraph.NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00012910 File Offset: 0x00010B10
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr, ref this));
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00012922 File Offset: 0x00010B22
		public void Disconnect<U>(U input, int inputPort) where U : struct
		{
			this.DisconnectInternal(input.GetHandle(), inputPort);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0001293A File Offset: 0x00010B3A
		public void DestroyPlayable<U>(U playable) where U : struct
		{
			this.DestroyPlayableInternal(playable.GetHandle());
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00012951 File Offset: 0x00010B51
		public void DestroySubgraph<U>(U playable) where U : struct
		{
			this.DestroySubgraphInternal(playable.GetHandle());
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00012968 File Offset: 0x00010B68
		public void DestroyOutput<U>(U output) where U : struct
		{
			this.DestroyOutputInternal(output.GetHandle());
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000A34A0 File Offset: 0x000A16A0
		public int GetOutputCountByType<T>() where T : struct
		{
			return this.GetOutputCountByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000A34C4 File Offset: 0x000A16C4
		public PlayableOutput GetOutput(int index)
		{
			PlayableOutputHandle handle;
			bool flag = !this.GetOutputInternal(index, out handle);
			PlayableOutput result;
			if (flag)
			{
				result = PlayableOutput.Null;
			}
			else
			{
				result = new PlayableOutput(handle);
			}
			return result;
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000A34F4 File Offset: 0x000A16F4
		public PlayableOutput GetOutputByType<T>(int index) where T : struct
		{
			PlayableOutputHandle handle;
			bool flag = !this.GetOutputByTypeInternal(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), index, out handle);
			PlayableOutput result;
			if (flag)
			{
				result = PlayableOutput.Null;
			}
			else
			{
				result = new PlayableOutput(handle);
			}
			return result;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000A3530 File Offset: 0x000A1730
		public static PlayableGraph Create()
		{
			return PlayableGraph.Create(null);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000A3548 File Offset: 0x000A1748
		public static PlayableGraph Create(string name)
		{
			PlayableGraph result;
			PlayableGraph.Create_Injected(name, out result);
			return result;
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x0001297F File Offset: 0x00010B7F
		public void Destroy()
		{
			PlayableGraph.Destroy_Injected(ref this);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00012987 File Offset: 0x00010B87
		public bool IsDone()
		{
			return PlayableGraph.IsDone_Injected(ref this);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x0001298F File Offset: 0x00010B8F
		public void Play()
		{
			PlayableGraph.Play_Injected(ref this);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00012997 File Offset: 0x00010B97
		public void Stop()
		{
			PlayableGraph.Stop_Injected(ref this);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x0001299F File Offset: 0x00010B9F
		public DirectorUpdateMode GetTimeUpdateMode()
		{
			return PlayableGraph.GetTimeUpdateMode_Injected(ref this);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000129A7 File Offset: 0x00010BA7
		public void SetTimeUpdateMode(DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_Injected(ref this, value);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000129B0 File Offset: 0x00010BB0
		public void SetResolver(IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_Injected(ref this, value);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000129B9 File Offset: 0x00010BB9
		public int GetOutputCount()
		{
			return PlayableGraph.GetOutputCount_Injected(ref this);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000129C1 File Offset: 0x00010BC1
		public void DestroyOutputInternal(PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_Injected(ref this, ref handle);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000129CB File Offset: 0x00010BCB
		public void EnableMatchFrameRate(FrameRate frameRate)
		{
			PlayableGraph.EnableMatchFrameRate_Injected(ref this, ref frameRate);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000129D5 File Offset: 0x00010BD5
		public void DisableMatchFrameRate()
		{
			PlayableGraph.DisableMatchFrameRate_Injected(ref this);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000129DD File Offset: 0x00010BDD
		public bool GetOutputInternal(int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_Injected(ref this, index, out handle);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000129E7 File Offset: 0x00010BE7
		public int GetOutputCountByTypeInternal(Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_Injected(ref this, outputType);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000129F0 File Offset: 0x00010BF0
		public bool GetOutputByTypeInternal(Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_Injected(ref this, outputType, index, out handle);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000129FB File Offset: 0x00010BFB
		public void DisconnectInternal(PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_Injected(ref this, ref playable, inputPort);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00012A06 File Offset: 0x00010C06
		public void DestroyPlayableInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00012A10 File Offset: 0x00010C10
		public void DestroySubgraphInternal(PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_Injected(ref this, ref playable);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00012A1A File Offset: 0x00010C1A
		public static void Create_Injected(string name, out PlayableGraph ret)
		{
			PlayableGraph.Create_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00012A2D File Offset: 0x00010C2D
		public static void Destroy_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Destroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00012A3A File Offset: 0x00010C3A
		public static bool IsDone_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00012A47 File Offset: 0x00010C47
		public static void Play_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00012A54 File Offset: 0x00010C54
		public static void Stop_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.Stop_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00012A61 File Offset: 0x00010C61
		public static DirectorUpdateMode GetTimeUpdateMode_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetTimeUpdateMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00012A6E File Offset: 0x00010C6E
		public static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value)
		{
			PlayableGraph.SetTimeUpdateMode_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00012A7C File Offset: 0x00010C7C
		public static void SetResolver_Injected(ref PlayableGraph _unity_self, IExposedPropertyTable value)
		{
			PlayableGraph.SetResolver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(value));
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00012A8F File Offset: 0x00010C8F
		public static int GetOutputCount_Injected(ref PlayableGraph _unity_self)
		{
			return PlayableGraph.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00012A9C File Offset: 0x00010C9C
		public static void DestroyOutputInternal_Injected(ref PlayableGraph _unity_self, ref PlayableOutputHandle handle)
		{
			PlayableGraph.DestroyOutputInternal_InjectedDelegateField(ref _unity_self, ref handle);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00012AAA File Offset: 0x00010CAA
		public static void EnableMatchFrameRate_Injected(ref PlayableGraph _unity_self, ref FrameRate frameRate)
		{
			PlayableGraph.EnableMatchFrameRate_InjectedDelegateField(ref _unity_self, ref frameRate);
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x00012AB8 File Offset: 0x00010CB8
		public static void DisableMatchFrameRate_Injected(ref PlayableGraph _unity_self)
		{
			PlayableGraph.DisableMatchFrameRate_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00012AC5 File Offset: 0x00010CC5
		public static bool GetOutputInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputInternal_InjectedDelegateField(ref _unity_self, index, out handle);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00012AD4 File Offset: 0x00010CD4
		public static int GetOutputCountByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType)
		{
			return PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType));
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00012AE7 File Offset: 0x00010CE7
		public static bool GetOutputByTypeInternal_Injected(ref PlayableGraph _unity_self, Type outputType, int index, out PlayableOutputHandle handle)
		{
			return PlayableGraph.GetOutputByTypeInternal_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(outputType), index, out handle);
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00012AFC File Offset: 0x00010CFC
		public static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort)
		{
			PlayableGraph.DisconnectInternal_InjectedDelegateField(ref _unity_self, ref playable, inputPort);
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00012B0B File Offset: 0x00010D0B
		public static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroyPlayableInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00012B19 File Offset: 0x00010D19
		public static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable)
		{
			PlayableGraph.DestroySubgraphInternal_InjectedDelegateField(ref _unity_self, ref playable);
		}

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayable_Public_Playable_Int32_0;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Single_0;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Public_IExposedPropertyTable_0;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableCount_Public_Int32_0;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Public_Int32_0;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Internal_Void_PlayableGraph_0;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Internal_PlayableHandle_0;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Internal_Boolean_String_byref_PlayableOutputHandle_0;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Internal_PlayableHandle_Int32_0;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchFrameRateEnabled_Internal_Boolean_0;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameRate_Internal_FrameRate_0;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeMethodInfoPtr_ConnectInternal_Private_Boolean_PlayableHandle_Int32_PlayableHandle_Int32_0;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableGraph_0;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Injected_Private_Static_Boolean_byref_PlayableGraph_0;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Void_byref_PlayableGraph_Single_0;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Injected_Private_Static_IExposedPropertyTable_byref_PlayableGraph_0;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableCount_Injected_Private_Static_Int32_byref_PlayableGraph_0;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizeEvaluation_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableGraph_0;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayableHandle_Injected_Private_Static_Void_byref_PlayableGraph_byref_PlayableHandle_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutputInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_String_byref_PlayableOutputHandle_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_GetRootPlayableInternal_Injected_Private_Static_Void_byref_PlayableGraph_Int32_byref_PlayableHandle_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchFrameRateEnabled_Injected_Private_Static_Boolean_byref_PlayableGraph_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_GetFrameRate_Injected_Private_Static_Void_byref_PlayableGraph_byref_FrameRate_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_ConnectInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_PlayableHandle_Int32_byref_PlayableHandle_Int32_0;

		// Token: 0x04002361 RID: 9057
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x04002362 RID: 9058
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x04002363 RID: 9059
		private static readonly PlayableGraph.Create_InjectedDelegate Create_InjectedDelegateField;

		// Token: 0x04002364 RID: 9060
		private static readonly PlayableGraph.Destroy_InjectedDelegate Destroy_InjectedDelegateField;

		// Token: 0x04002365 RID: 9061
		private static readonly PlayableGraph.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x04002366 RID: 9062
		private static readonly PlayableGraph.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x04002367 RID: 9063
		private static readonly PlayableGraph.Stop_InjectedDelegate Stop_InjectedDelegateField;

		// Token: 0x04002368 RID: 9064
		private static readonly PlayableGraph.GetTimeUpdateMode_InjectedDelegate GetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x04002369 RID: 9065
		private static readonly PlayableGraph.SetTimeUpdateMode_InjectedDelegate SetTimeUpdateMode_InjectedDelegateField;

		// Token: 0x0400236A RID: 9066
		private static readonly PlayableGraph.SetResolver_InjectedDelegate SetResolver_InjectedDelegateField;

		// Token: 0x0400236B RID: 9067
		private static readonly PlayableGraph.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x0400236C RID: 9068
		private static readonly PlayableGraph.DestroyOutputInternal_InjectedDelegate DestroyOutputInternal_InjectedDelegateField;

		// Token: 0x0400236D RID: 9069
		private static readonly PlayableGraph.EnableMatchFrameRate_InjectedDelegate EnableMatchFrameRate_InjectedDelegateField;

		// Token: 0x0400236E RID: 9070
		private static readonly PlayableGraph.DisableMatchFrameRate_InjectedDelegate DisableMatchFrameRate_InjectedDelegateField;

		// Token: 0x0400236F RID: 9071
		private static readonly PlayableGraph.GetOutputInternal_InjectedDelegate GetOutputInternal_InjectedDelegateField;

		// Token: 0x04002370 RID: 9072
		private static readonly PlayableGraph.GetOutputCountByTypeInternal_InjectedDelegate GetOutputCountByTypeInternal_InjectedDelegateField;

		// Token: 0x04002371 RID: 9073
		private static readonly PlayableGraph.GetOutputByTypeInternal_InjectedDelegate GetOutputByTypeInternal_InjectedDelegateField;

		// Token: 0x04002372 RID: 9074
		private static readonly PlayableGraph.DisconnectInternal_InjectedDelegate DisconnectInternal_InjectedDelegateField;

		// Token: 0x04002373 RID: 9075
		private static readonly PlayableGraph.DestroyPlayableInternal_InjectedDelegate DestroyPlayableInternal_InjectedDelegateField;

		// Token: 0x04002374 RID: 9076
		private static readonly PlayableGraph.DestroySubgraphInternal_InjectedDelegate DestroySubgraphInternal_InjectedDelegateField;

		// Token: 0x02000BB1 RID: 2993
		private sealed class MethodInfoStoreGeneric_Connect_Public_Boolean_U_Int32_V_Int32_0<U, V>
		{
			// Token: 0x04002C13 RID: 11283
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableGraph.NativeMethodInfoPtr_Connect_Public_Boolean_U_Int32_V_Int32_0, Il2CppClassPointerStore<PlayableGraph>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BB2 RID: 2994
		// (Invoke) Token: 0x06004035 RID: 16437
		private delegate void Create_InjectedDelegate(IntPtr name, [Out] IntPtr ret);

		// Token: 0x02000BB3 RID: 2995
		// (Invoke) Token: 0x06004037 RID: 16439
		private delegate void Destroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BB4 RID: 2996
		// (Invoke) Token: 0x06004039 RID: 16441
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BB5 RID: 2997
		// (Invoke) Token: 0x0600403B RID: 16443
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BB6 RID: 2998
		// (Invoke) Token: 0x0600403D RID: 16445
		private delegate void Stop_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BB7 RID: 2999
		// (Invoke) Token: 0x0600403F RID: 16447
		private delegate DirectorUpdateMode GetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BB8 RID: 3000
		// (Invoke) Token: 0x06004041 RID: 16449
		private delegate void SetTimeUpdateMode_InjectedDelegate(IntPtr _unity_self, DirectorUpdateMode value);

		// Token: 0x02000BB9 RID: 3001
		// (Invoke) Token: 0x06004043 RID: 16451
		private delegate void SetResolver_InjectedDelegate(IntPtr _unity_self, IntPtr value);

		// Token: 0x02000BBA RID: 3002
		// (Invoke) Token: 0x06004045 RID: 16453
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BBB RID: 3003
		// (Invoke) Token: 0x06004047 RID: 16455
		private delegate void DestroyOutputInternal_InjectedDelegate(IntPtr _unity_self, IntPtr handle);

		// Token: 0x02000BBC RID: 3004
		// (Invoke) Token: 0x06004049 RID: 16457
		private delegate void EnableMatchFrameRate_InjectedDelegate(IntPtr _unity_self, IntPtr frameRate);

		// Token: 0x02000BBD RID: 3005
		// (Invoke) Token: 0x0600404B RID: 16459
		private delegate void DisableMatchFrameRate_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BBE RID: 3006
		// (Invoke) Token: 0x0600404D RID: 16461
		private delegate bool GetOutputInternal_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr handle);

		// Token: 0x02000BBF RID: 3007
		// (Invoke) Token: 0x0600404F RID: 16463
		private delegate int GetOutputCountByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType);

		// Token: 0x02000BC0 RID: 3008
		// (Invoke) Token: 0x06004051 RID: 16465
		private delegate bool GetOutputByTypeInternal_InjectedDelegate(IntPtr _unity_self, IntPtr outputType, int index, [Out] IntPtr handle);

		// Token: 0x02000BC1 RID: 3009
		// (Invoke) Token: 0x06004053 RID: 16467
		private delegate void DisconnectInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable, int inputPort);

		// Token: 0x02000BC2 RID: 3010
		// (Invoke) Token: 0x06004055 RID: 16469
		private delegate void DestroyPlayableInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);

		// Token: 0x02000BC3 RID: 3011
		// (Invoke) Token: 0x06004057 RID: 16471
		private delegate void DestroySubgraphInternal_InjectedDelegate(IntPtr _unity_self, IntPtr playable);
	}
}
