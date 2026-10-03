using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000259 RID: 601
	public static class PlayableExtensions : Object
	{
		// Token: 0x06002970 RID: 10608 RVA: 0x000A1660 File Offset: 0x0009F860
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableExtensions()
		{
			Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr);
			PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667718);
			PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667719);
			PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667720);
			PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667721);
			PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667722);
			PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667723);
			PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667724);
			PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667725);
			PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667726);
			PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667727);
			PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667728);
			PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667729);
			PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667730);
			PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667731);
			PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667732);
			PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667733);
			PlayableExtensions.NativeMethodInfoPtr_GetOutput_Public_Static_Playable_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667734);
			PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667735);
			PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667736);
			PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667737);
			PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667738);
			PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667739);
			PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr, 100667740);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000A185C File Offset: 0x0009FA5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1292767, RefRangeEnd = 1292770, XrefRangeStart = 1292759, XrefRangeEnd = 1292767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000A18E8 File Offset: 0x0009FAE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292779, RefRangeEnd = 1292783, XrefRangeStart = 1292770, XrefRangeEnd = 1292779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableGraph GetGraph<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000A1974 File Offset: 0x0009FB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292792, RefRangeEnd = 1292794, XrefRangeStart = 1292783, XrefRangeEnd = 1292792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayState GetPlayState<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000A1A00 File Offset: 0x0009FC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292803, RefRangeEnd = 1292805, XrefRangeStart = 1292794, XrefRangeEnd = 1292803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000A1A84 File Offset: 0x0009FC84
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1292814, RefRangeEnd = 1292822, XrefRangeStart = 1292805, XrefRangeEnd = 1292814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000A1B08 File Offset: 0x0009FD08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292831, RefRangeEnd = 1292835, XrefRangeStart = 1292822, XrefRangeEnd = 1292831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpeed<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000A1B98 File Offset: 0x0009FD98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292843, RefRangeEnd = 1292845, XrefRangeStart = 1292835, XrefRangeEnd = 1292843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDuration<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000A1C28 File Offset: 0x0009FE28
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1292854, RefRangeEnd = 1292862, XrefRangeStart = 1292845, XrefRangeEnd = 1292854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDuration<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000A1CB4 File Offset: 0x0009FEB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1292871, RefRangeEnd = 1292880, XrefRangeStart = 1292862, XrefRangeEnd = 1292871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTime<U>(this U playable, double value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000A1D44 File Offset: 0x0009FF44
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1292889, RefRangeEnd = 1292907, XrefRangeStart = 1292880, XrefRangeEnd = 1292889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetTime<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000A1DD0 File Offset: 0x0009FFD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292916, RefRangeEnd = 1292918, XrefRangeStart = 1292907, XrefRangeEnd = 1292916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetPreviousTime<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000A1E5C File Offset: 0x000A005C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292927, RefRangeEnd = 1292928, XrefRangeStart = 1292918, XrefRangeEnd = 1292927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDone<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000A1EE8 File Offset: 0x000A00E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292936, RefRangeEnd = 1292938, XrefRangeStart = 1292928, XrefRangeEnd = 1292936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPropagateSetTime<U>(this U playable, bool value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000A1F78 File Offset: 0x000A0178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292946, RefRangeEnd = 1292947, XrefRangeStart = 1292938, XrefRangeEnd = 1292946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputCount<U>(this U playable, int value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000A2008 File Offset: 0x000A0208
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1292956, RefRangeEnd = 1292964, XrefRangeStart = 1292947, XrefRangeEnd = 1292956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInputCount<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000A2094 File Offset: 0x000A0294
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1292973, RefRangeEnd = 1292978, XrefRangeStart = 1292964, XrefRangeEnd = 1292973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable GetInput<U>(this U playable, int inputPort) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000A2130 File Offset: 0x000A0330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292987, RefRangeEnd = 1292988, XrefRangeStart = 1292978, XrefRangeEnd = 1292987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable GetOutput<U>(this U playable, int outputPort) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetOutput_Public_Static_Playable_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000A21CC File Offset: 0x000A03CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292997, RefRangeEnd = 1292998, XrefRangeStart = 1292988, XrefRangeEnd = 1292997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight<U>(this U playable, int inputIndex, float weight) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000A226C File Offset: 0x000A046C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293010, RefRangeEnd = 1293011, XrefRangeStart = 1292998, XrefRangeEnd = 1293010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInputWeight<U, V>(this U playable, V input, float weight) where U : new() where V : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = input;
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
				ptr7 = ref input;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000A2358 File Offset: 0x000A0558
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1293020, RefRangeEnd = 1293024, XrefRangeStart = 1293011, XrefRangeEnd = 1293020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetInputWeight<U>(this U playable, int inputIndex) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000A23F4 File Offset: 0x000A05F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293032, RefRangeEnd = 1293033, XrefRangeStart = 1293024, XrefRangeEnd = 1293032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTraversalMode<U>(this U playable, PlayableTraversalMode mode) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000A2484 File Offset: 0x000A0684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293042, RefRangeEnd = 1293044, XrefRangeStart = 1293033, XrefRangeEnd = 1293042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectorWrapMode GetTimeWrapMode<U>(this U playable) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000A2510 File Offset: 0x000A0710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293052, RefRangeEnd = 1293053, XrefRangeStart = 1293044, XrefRangeEnd = 1293052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTimeWrapMode<U>(this U playable, DirectorWrapMode value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = playable;
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
				ptr4 = ref playable;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableExtensions.MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000128F5 File Offset: 0x00010AF5
		public PlayableExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000A25A0 File Offset: 0x000A07A0
		public static bool IsNull<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsNull();
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000A25C8 File Offset: 0x000A07C8
		public static void Destroy<U>(U playable) where U : struct
		{
			playable.GetHandle().Destroy();
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000A25EC File Offset: 0x000A07EC
		public static void SetPlayState<U>(U playable, PlayState value) where U : struct
		{
			bool flag = value == PlayState.Delayed;
			if (flag)
			{
				throw new ArgumentException("Can't set Delayed: use SetDelay() instead");
			}
			if (value != PlayState.Paused)
			{
				if (value == PlayState.Playing)
				{
					playable.GetHandle().Play();
				}
			}
			else
			{
				playable.GetHandle().Pause();
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000A264C File Offset: 0x000A084C
		public static double GetSpeed<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetSpeed();
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000A2674 File Offset: 0x000A0874
		public static void SetDone<U>(U playable, bool value) where U : struct
		{
			playable.GetHandle().SetDone(value);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000A269C File Offset: 0x000A089C
		public static bool GetPropagateSetTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetPropagateSetTime();
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000A26C4 File Offset: 0x000A08C4
		public static bool CanChangeInputs<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanChangeInputs();
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000A26EC File Offset: 0x000A08EC
		public static bool CanSetWeights<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanSetWeights();
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000A2714 File Offset: 0x000A0914
		public static bool CanDestroy<U>(U playable) where U : struct
		{
			return playable.GetHandle().CanDestroy();
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000A273C File Offset: 0x000A093C
		public static void SetOutputCount<U>(U playable, int value) where U : struct
		{
			playable.GetHandle().SetOutputCount(value);
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000A2764 File Offset: 0x000A0964
		public static int GetOutputCount<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetOutputCount();
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000128FE File Offset: 0x00010AFE
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) where U : struct where V : struct
		{
			PlayableExtensions.ConnectInput<U, V>(playable, inputIndex, sourcePlayable, sourceOutputIndex, 0f);
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000A278C File Offset: 0x000A098C
		public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) where U : struct where V : struct
		{
			playable.GetGraph<U>().Connect<V, U>(sourcePlayable, sourceOutputIndex, playable, inputIndex);
			playable.SetInputWeight(inputIndex, weight);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000A27B8 File Offset: 0x000A09B8
		public static void DisconnectInput<U>(U playable, int inputPort) where U : struct
		{
			playable.GetGraph<U>().Disconnect<U>(playable, inputPort);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000A27D8 File Offset: 0x000A09D8
		public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, [Optional] float weight) where U : struct where V : struct
		{
			int inputCount = playable.GetInputCount<U>();
			playable.SetInputCount(inputCount + 1);
			PlayableExtensions.ConnectInput<U, V>(playable, inputCount, sourcePlayable, sourceOutputIndex, weight);
			return inputCount;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000A2808 File Offset: 0x000A0A08
		public static void SetDelay<U>(U playable, double delay) where U : struct
		{
			playable.GetHandle().SetDelay(delay);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000A2830 File Offset: 0x000A0A30
		public static double GetDelay<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetDelay();
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000A2858 File Offset: 0x000A0A58
		public static bool IsDelayed<U>(U playable) where U : struct
		{
			return playable.GetHandle().IsDelayed();
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000A2880 File Offset: 0x000A0A80
		public static void SetLeadTime<U>(U playable, float value) where U : struct
		{
			playable.GetHandle().SetLeadTime(value);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000A28A8 File Offset: 0x000A0AA8
		public static float GetLeadTime<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetLeadTime();
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000A28D0 File Offset: 0x000A0AD0
		public static PlayableTraversalMode GetTraversalMode<U>(U playable) where U : struct
		{
			return playable.GetHandle().GetTraversalMode();
		}

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_U_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_U_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Public_Static_Playable_U_Int32_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0;

		// Token: 0x02000B9A RID: 2970
		private sealed class MethodInfoStoreGeneric_IsValid_Public_Static_Boolean_U_0<U>
		{
			// Token: 0x04002BFC RID: 11260
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B9B RID: 2971
		private sealed class MethodInfoStoreGeneric_GetGraph_Public_Static_PlayableGraph_U_0<U>
		{
			// Token: 0x04002BFD RID: 11261
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetGraph_Public_Static_PlayableGraph_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B9C RID: 2972
		private sealed class MethodInfoStoreGeneric_GetPlayState_Public_Static_PlayState_U_0<U>
		{
			// Token: 0x04002BFE RID: 11262
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPlayState_Public_Static_PlayState_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B9D RID: 2973
		private sealed class MethodInfoStoreGeneric_Play_Public_Static_Void_U_0<U>
		{
			// Token: 0x04002BFF RID: 11263
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Play_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B9E RID: 2974
		private sealed class MethodInfoStoreGeneric_Pause_Public_Static_Void_U_0<U>
		{
			// Token: 0x04002C00 RID: 11264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_Pause_Public_Static_Void_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B9F RID: 2975
		private sealed class MethodInfoStoreGeneric_SetSpeed_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04002C01 RID: 11265
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetSpeed_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA0 RID: 2976
		private sealed class MethodInfoStoreGeneric_SetDuration_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04002C02 RID: 11266
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetDuration_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA1 RID: 2977
		private sealed class MethodInfoStoreGeneric_GetDuration_Public_Static_Double_U_0<U>
		{
			// Token: 0x04002C03 RID: 11267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetDuration_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA2 RID: 2978
		private sealed class MethodInfoStoreGeneric_SetTime_Public_Static_Void_U_Double_0<U>
		{
			// Token: 0x04002C04 RID: 11268
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTime_Public_Static_Void_U_Double_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA3 RID: 2979
		private sealed class MethodInfoStoreGeneric_GetTime_Public_Static_Double_U_0<U>
		{
			// Token: 0x04002C05 RID: 11269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA4 RID: 2980
		private sealed class MethodInfoStoreGeneric_GetPreviousTime_Public_Static_Double_U_0<U>
		{
			// Token: 0x04002C06 RID: 11270
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetPreviousTime_Public_Static_Double_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA5 RID: 2981
		private sealed class MethodInfoStoreGeneric_IsDone_Public_Static_Boolean_U_0<U>
		{
			// Token: 0x04002C07 RID: 11271
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_IsDone_Public_Static_Boolean_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA6 RID: 2982
		private sealed class MethodInfoStoreGeneric_SetPropagateSetTime_Public_Static_Void_U_Boolean_0<U>
		{
			// Token: 0x04002C08 RID: 11272
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetPropagateSetTime_Public_Static_Void_U_Boolean_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA7 RID: 2983
		private sealed class MethodInfoStoreGeneric_SetInputCount_Public_Static_Void_U_Int32_0<U>
		{
			// Token: 0x04002C09 RID: 11273
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputCount_Public_Static_Void_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA8 RID: 2984
		private sealed class MethodInfoStoreGeneric_GetInputCount_Public_Static_Int32_U_0<U>
		{
			// Token: 0x04002C0A RID: 11274
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputCount_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BA9 RID: 2985
		private sealed class MethodInfoStoreGeneric_GetInput_Public_Static_Playable_U_Int32_0<U>
		{
			// Token: 0x04002C0B RID: 11275
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInput_Public_Static_Playable_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAA RID: 2986
		private sealed class MethodInfoStoreGeneric_GetOutput_Public_Static_Playable_U_Int32_0<U>
		{
			// Token: 0x04002C0C RID: 11276
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetOutput_Public_Static_Playable_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAB RID: 2987
		private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_Int32_Single_0<U>
		{
			// Token: 0x04002C0D RID: 11277
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_Int32_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAC RID: 2988
		private sealed class MethodInfoStoreGeneric_SetInputWeight_Public_Static_Void_U_V_Single_0<U, V>
		{
			// Token: 0x04002C0E RID: 11278
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetInputWeight_Public_Static_Void_U_V_Single_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAD RID: 2989
		private sealed class MethodInfoStoreGeneric_GetInputWeight_Public_Static_Single_U_Int32_0<U>
		{
			// Token: 0x04002C0F RID: 11279
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetInputWeight_Public_Static_Single_U_Int32_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAE RID: 2990
		private sealed class MethodInfoStoreGeneric_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0<U>
		{
			// Token: 0x04002C10 RID: 11280
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTraversalMode_Public_Static_Void_U_PlayableTraversalMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BAF RID: 2991
		private sealed class MethodInfoStoreGeneric_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0<U>
		{
			// Token: 0x04002C11 RID: 11281
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_GetTimeWrapMode_Internal_Static_DirectorWrapMode_U_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BB0 RID: 2992
		private sealed class MethodInfoStoreGeneric_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0<U>
		{
			// Token: 0x04002C12 RID: 11282
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableExtensions.NativeMethodInfoPtr_SetTimeWrapMode_Internal_Static_Void_U_DirectorWrapMode_0, Il2CppClassPointerStore<PlayableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}
	}
}
