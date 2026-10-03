using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000767 RID: 1895
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x0600B899 RID: 47257 RVA: 0x002FA438 File Offset: 0x002F8638
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedObject()
		{
			Il2CppClassPointerStore<MaskedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MaskedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr);
			MaskedObject.NativeFieldInfoPtr_canvasRendererToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRendererToClip");
			MaskedObject.NativeFieldInfoPtr_includeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "includeChildren");
			MaskedObject.NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "rootCanvas");
			MaskedObject.NativeFieldInfoPtr_maskRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "maskRectTransform");
			MaskedObject.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "initialized");
			MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRenderersToClip");
			MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687439);
			MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687440);
			MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687441);
			MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687442);
			MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687443);
			MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100687444);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x002FA558 File Offset: 0x002F8758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309188, XrefRangeEnd = 309190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x002FA594 File Offset: 0x002F8794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309190, XrefRangeEnd = 309194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x002FA5D0 File Offset: 0x002F87D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309194, XrefRangeEnd = 309212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x002FA60C File Offset: 0x002F880C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309212, XrefRangeEnd = 309215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maskRectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x002FA660 File Offset: 0x002F8860
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 309234, RefRangeEnd = 309238, XrefRangeStart = 309215, XrefRangeEnd = 309234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x002FA694 File Offset: 0x002F8894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309238, XrefRangeEnd = 309246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskedObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x00055D43 File Offset: 0x00053F43
		public MaskedObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600B8A1 RID: 47265 RVA: 0x002FA6D0 File Offset: 0x002F88D0
		// (set) Token: 0x0600B8A2 RID: 47266 RVA: 0x00055D4C File Offset: 0x00053F4C
		public unsafe CanvasRenderer canvasRendererToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600B8A3 RID: 47267 RVA: 0x002FA700 File Offset: 0x002F8900
		// (set) Token: 0x0600B8A4 RID: 47268 RVA: 0x00055D6B File Offset: 0x00053F6B
		public unsafe bool includeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren)) = value;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002FA728 File Offset: 0x002F8928
		// (set) Token: 0x0600B8A6 RID: 47270 RVA: 0x00055D86 File Offset: 0x00053F86
		public unsafe Canvas rootCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002FA758 File Offset: 0x002F8958
		// (set) Token: 0x0600B8A8 RID: 47272 RVA: 0x00055DA5 File Offset: 0x00053FA5
		public unsafe RectTransform maskRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600B8A9 RID: 47273 RVA: 0x002FA788 File Offset: 0x002F8988
		// (set) Token: 0x0600B8AA RID: 47274 RVA: 0x00055DC4 File Offset: 0x00053FC4
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002FA7B0 File Offset: 0x002F89B0
		// (set) Token: 0x0600B8AC RID: 47276 RVA: 0x00055DDF File Offset: 0x00053FDF
		public unsafe List<CanvasRenderer> canvasRenderersToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007EB7 RID: 32439
		private static readonly IntPtr NativeFieldInfoPtr_canvasRendererToClip;

		// Token: 0x04007EB8 RID: 32440
		private static readonly IntPtr NativeFieldInfoPtr_includeChildren;

		// Token: 0x04007EB9 RID: 32441
		private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

		// Token: 0x04007EBA RID: 32442
		private static readonly IntPtr NativeFieldInfoPtr_maskRectTransform;

		// Token: 0x04007EBB RID: 32443
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04007EBC RID: 32444
		private static readonly IntPtr NativeFieldInfoPtr_canvasRenderersToClip;

		// Token: 0x04007EBD RID: 32445
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04007EBE RID: 32446
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007EBF RID: 32447
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007EC0 RID: 32448
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0;

		// Token: 0x04007EC1 RID: 32449
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0;

		// Token: 0x04007EC2 RID: 32450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
