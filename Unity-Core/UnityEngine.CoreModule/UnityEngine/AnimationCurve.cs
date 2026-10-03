using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000069 RID: 105
	public class AnimationCurve : Object
	{
		// Token: 0x0600034B RID: 843 RVA: 0x00021C94 File Offset: 0x0001FE94
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationCurve()
		{
			Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AnimationCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr);
			AnimationCurve.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "m_Ptr");
			AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663631);
			AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663632);
			AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663633);
			AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663634);
			AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663635);
			AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663636);
			AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663637);
			AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663638);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663639);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663640);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663641);
			AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663642);
			AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663643);
			AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663644);
			AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663645);
			AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663646);
			AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663647);
			AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663648);
			AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663649);
			AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663650);
			AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663651);
			AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663652);
			AnimationCurve.NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663653);
			AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663654);
			AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663655);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663656);
			AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663657);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663658);
			AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663659);
			AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663660);
			AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663661);
			AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663662);
			AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663663);
			AnimationCurve.get_preWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_preWrapModeDelegate>("UnityEngine.AnimationCurve::get_preWrapMode");
			AnimationCurve.get_postWrapModeDelegateField = IL2CPP.ResolveICall<AnimationCurve.get_postWrapModeDelegate>("UnityEngine.AnimationCurve::get_postWrapMode");
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00021F8C File Offset: 0x0002018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226837, XrefRangeEnd = 1226839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00021FC0 File Offset: 0x000201C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226839, XrefRangeEnd = 1226841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(Il2CppStructArray<Keyframe> keys)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00022004 File Offset: 0x00020204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226841, XrefRangeEnd = 1226843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00022050 File Offset: 0x00020250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226843, XrefRangeEnd = 1226845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_CopyFrom(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00022090 File Offset: 0x00020290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226845, XrefRangeEnd = 1226850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000220CC File Offset: 0x000202CC
		[CallerCount(156)]
		[CachedScanResults(RefRangeStart = 1226852, RefRangeEnd = 1227008, XrefRangeStart = 1226850, XrefRangeEnd = 1226852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00022118 File Offset: 0x00020318
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00022158 File Offset: 0x00020358
		public unsafe Il2CppStructArray<Keyframe> keys
		{
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 1227010, RefRangeEnd = 1227064, XrefRangeStart = 1227008, XrefRangeEnd = 1227010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
			}
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1227066, RefRangeEnd = 1227103, XrefRangeStart = 1227064, XrefRangeEnd = 1227066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0002219C File Offset: 0x0002039C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1227105, RefRangeEnd = 1227143, XrefRangeStart = 1227103, XrefRangeEnd = 1227105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey(float time, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x000221F4 File Offset: 0x000203F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1227145, RefRangeEnd = 1227148, XrefRangeStart = 1227143, XrefRangeEnd = 1227145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey(Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00022240 File Offset: 0x00020440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227148, XrefRangeEnd = 1227150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey_Internal(Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0002228C File Offset: 0x0002048C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227152, RefRangeEnd = 1227153, XrefRangeStart = 1227150, XrefRangeEnd = 1227152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MoveKey(int index, Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000222E4 File Offset: 0x000204E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1227155, RefRangeEnd = 1227157, XrefRangeStart = 1227153, XrefRangeEnd = 1227155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_ClearKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00022318 File Offset: 0x00020518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227159, RefRangeEnd = 1227160, XrefRangeStart = 1227157, XrefRangeEnd = 1227159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A3 RID: 163
		public unsafe Keyframe this[int index]
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1227162, RefRangeEnd = 1227167, XrefRangeStart = 1227160, XrefRangeEnd = 1227162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000223A4 File Offset: 0x000205A4
		public unsafe int length
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1227169, RefRangeEnd = 1227198, XrefRangeStart = 1227167, XrefRangeEnd = 1227169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000223E0 File Offset: 0x000205E0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1227066, RefRangeEnd = 1227103, XrefRangeStart = 1227066, XrefRangeEnd = 1227103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeys(Il2CppStructArray<Keyframe> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00022424 File Offset: 0x00020624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227198, XrefRangeEnd = 1227200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Keyframe GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00022470 File Offset: 0x00020670
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 1227010, RefRangeEnd = 1227064, XrefRangeStart = 1227010, XrefRangeEnd = 1227064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Keyframe> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr3) : null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000224B0 File Offset: 0x000206B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227200, XrefRangeEnd = 1227202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000224F8 File Offset: 0x000206F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227204, RefRangeEnd = 1227205, XrefRangeStart = 1227202, XrefRangeEnd = 1227204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SmoothTangents(int index, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00022544 File Offset: 0x00020744
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1227217, RefRangeEnd = 1227242, XrefRangeStart = 1227205, XrefRangeEnd = 1227217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x000225B0 File Offset: 0x000207B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1227254, RefRangeEnd = 1227262, XrefRangeStart = 1227242, XrefRangeEnd = 1227254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref timeStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00003AAA File Offset: 0x00001CAA
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0002261C File Offset: 0x0002081C
		public unsafe WrapMode preWrapMode
		{
			get
			{
				return AnimationCurve.get_preWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227264, RefRangeEnd = 1227265, XrefRangeStart = 1227262, XrefRangeEnd = 1227264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00003ABC File Offset: 0x00001CBC
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0002265C File Offset: 0x0002085C
		public unsafe WrapMode postWrapMode
		{
			get
			{
				return AnimationCurve.get_postWrapModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1227267, RefRangeEnd = 1227268, XrefRangeStart = 1227265, XrefRangeEnd = 1227267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0002269C File Offset: 0x0002089C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1227271, RefRangeEnd = 1227293, XrefRangeStart = 1227268, XrefRangeEnd = 1227271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve([Optional] Il2CppStructArray<Keyframe> keys)
		{
			if (keys == null)
			{
				keys = new Il2CppStructArray<Keyframe>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr));
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000226F4 File Offset: 0x000208F4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1227296, RefRangeEnd = 1227322, XrefRangeStart = 1227293, XrefRangeEnd = 1227296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00022730 File Offset: 0x00020930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227322, XrefRangeEnd = 1227329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00022788 File Offset: 0x00020988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227329, XrefRangeEnd = 1227333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(AnimationCurve other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000227D8 File Offset: 0x000209D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227336, RefRangeEnd = 1227337, XrefRangeStart = 1227333, XrefRangeEnd = 1227336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(AnimationCurve other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0002281C File Offset: 0x00020A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227337, XrefRangeEnd = 1227339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey_Internal_Injected(ref Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00022868 File Offset: 0x00020A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227339, XrefRangeEnd = 1227341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MoveKey_Injected(int index, ref Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000228C0 File Offset: 0x00020AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227341, XrefRangeEnd = 1227343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetKey_Injected(int index, out Keyframe ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationCurve.NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003A78 File Offset: 0x00001C78
		public AnimationCurve(params Keyframe[] keys) : this(new Il2CppStructArray<Keyframe>(keys))
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003A86 File Offset: 0x00001C86
		public AnimationCurve(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0002290C File Offset: 0x00020B0C
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003A8F File Offset: 0x00001C8F
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationCurve.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00022934 File Offset: 0x00020B34
		public static AnimationCurve Constant(float timeStart, float timeEnd, float value)
		{
			return AnimationCurve.Linear(timeStart, value, timeEnd, value);
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_ClearKeys_Public_Void_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_set_preWrapMode_Public_set_Void_WrapMode_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_set_postWrapMode_Public_set_Void_WrapMode_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Int32_byref_Keyframe_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_MoveKey_Injected_Private_Int32_Int32_byref_Keyframe_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Injected_Private_Void_Int32_byref_Keyframe_0;

		// Token: 0x040002BA RID: 698
		private static readonly AnimationCurve.get_preWrapModeDelegate get_preWrapModeDelegateField;

		// Token: 0x040002BB RID: 699
		private static readonly AnimationCurve.get_postWrapModeDelegate get_postWrapModeDelegateField;

		// Token: 0x020003F7 RID: 1015
		// (Invoke) Token: 0x0600308E RID: 12430
		private delegate WrapMode get_preWrapModeDelegate(IntPtr @this);

		// Token: 0x020003F8 RID: 1016
		// (Invoke) Token: 0x06003090 RID: 12432
		private delegate WrapMode get_postWrapModeDelegate(IntPtr @this);
	}
}
