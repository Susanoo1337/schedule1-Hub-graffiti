using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200006A RID: 106
	public class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00090FE4 File Offset: 0x0008F1E4
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionAbstractBase()
		{
			Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr);
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "ClassName");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "updateRate");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "waitXFrames");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "onOcclusionProcessed");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_TransformPacked");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_LastFrameRendered");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_Master");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_MaterialModifierCallbackCached");
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664157);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664158);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664159);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664160);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664161);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664162);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664163);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664164);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664165);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664166);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664167);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664168);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664169);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664170);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664171);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664172);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664173);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664174);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100664176);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00091244 File Offset: 0x0008F444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72668, XrefRangeEnd = 72669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00091278 File Offset: 0x0008F478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72673, RefRangeEnd = 72674, XrefRangeStart = 72669, XrefRangeEnd = 72673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000912BC File Offset: 0x0008F4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72674, XrefRangeEnd = 72678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onOcclusionProcessed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00091300 File Offset: 0x0008F500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72698, RefRangeEnd = 72701, XrefRangeStart = 72678, XrefRangeEnd = 72698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00091340 File Offset: 0x0008F540
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 42871, RefRangeEnd = 42874, XrefRangeStart = 42871, XrefRangeEnd = 42874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0009137C File Offset: 0x0008F57C
		[CallerCount(0)]
		public unsafe virtual string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000913C0 File Offset: 0x0008F5C0
		[CallerCount(0)]
		public unsafe virtual MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00091408 File Offset: 0x0008F608
		[CallerCount(0)]
		public unsafe virtual bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0009145C File Offset: 0x0008F65C
		[CallerCount(0)]
		public unsafe virtual void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000914AC File Offset: 0x0008F6AC
		[CallerCount(0)]
		public unsafe virtual void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000914E8 File Offset: 0x0008F6E8
		[CallerCount(0)]
		public unsafe virtual void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00091524 File Offset: 0x0008F724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72701, XrefRangeEnd = 72705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00091560 File Offset: 0x0008F760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72705, XrefRangeEnd = 72707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0009159C File Offset: 0x0008F79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72707, XrefRangeEnd = 72748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000915D8 File Offset: 0x0008F7D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72761, RefRangeEnd = 72763, XrefRangeStart = 72748, XrefRangeEnd = 72761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00091614 File Offset: 0x0008F814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72763, XrefRangeEnd = 72773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRender(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00091658 File Offset: 0x0008F858
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72783, RefRangeEnd = 72786, XrefRangeStart = 72773, XrefRangeEnd = 72783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableOcclusion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0009168C File Offset: 0x0008F88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72786, XrefRangeEnd = 72787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000916C8 File Offset: 0x0008F8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72787, XrefRangeEnd = 72790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnEnable_b__24_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00005542 File Offset: 0x00003742
		public DynamicOcclusionAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000916FC File Offset: 0x0008F8FC
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x0000554B File Offset: 0x0000374B
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0009171C File Offset: 0x0008F91C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x0000555D File Offset: 0x0000375D
		public unsafe DynamicOcclusionUpdateRate updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00091744 File Offset: 0x0008F944
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00005578 File Offset: 0x00003778
		public unsafe int waitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0009176C File Offset: 0x0008F96C
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00005593 File Offset: 0x00003793
		public unsafe Action onOcclusionProcessed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_onOcclusionProcessed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0009179C File Offset: 0x0008F99C
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000055B2 File Offset: 0x000037B2
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000917B8 File Offset: 0x0008F9B8
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x000055C0 File Offset: 0x000037C0
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000917E0 File Offset: 0x0008F9E0
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x000055DB File Offset: 0x000037DB
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00091808 File Offset: 0x0008FA08
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x000055F6 File Offset: 0x000037F6
		public unsafe VolumetricLightBeamSD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00091838 File Offset: 0x0008FA38
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00005615 File Offset: 0x00003815
		public unsafe MaterialModifier.Callback m_MaterialModifierCallbackCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialModifier.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_MaterialModifierCallbackCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_updateRate;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_waitXFrames;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_onOcclusionProcessed;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallbackCached;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_add_onOcclusionProcessed_Public_add_Void_Action_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_remove_onOcclusionProcessed_Public_rem_Void_Action_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_DisableOcclusion_Private_Void_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__24_0_Private_Void_0;

		// Token: 0x02000888 RID: 2184
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x04008F59 RID: 36697
			RenderLoop,
			// Token: 0x04008F5A RID: 36698
			OnEnable,
			// Token: 0x04008F5B RID: 36699
			EditorUpdate,
			// Token: 0x04008F5C RID: 36700
			User
		}
	}
}
