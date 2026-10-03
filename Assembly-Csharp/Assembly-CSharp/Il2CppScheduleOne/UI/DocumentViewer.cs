using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.State;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072D RID: 1837
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x0600B15A RID: 45402 RVA: 0x002E4F3C File Offset: 0x002E313C
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentViewer()
		{
			Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DocumentViewer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr);
			DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "<IsOpen>k__BackingField");
			DocumentViewer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Canvas");
			DocumentViewer.NativeFieldInfoPtr_Documents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Documents");
			DocumentViewer.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "State");
			DocumentViewer.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "onOpen");
			DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686620);
			DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686621);
			DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686622);
			DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686623);
			DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686624);
			DocumentViewer.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686625);
			DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100686626);
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600B15B RID: 45403 RVA: 0x002E505C File Offset: 0x002E325C
		// (set) Token: 0x0600B15C RID: 45404 RVA: 0x002E5098 File Offset: 0x002E3298
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B15D RID: 45405 RVA: 0x002E50D8 File Offset: 0x002E32D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300971, XrefRangeEnd = 300990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B15E RID: 45406 RVA: 0x002E5114 File Offset: 0x002E3314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301005, RefRangeEnd = 301006, XrefRangeStart = 300990, XrefRangeEnd = 301005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string documentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(documentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x002E5158 File Offset: 0x002E3358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x002E518C File Offset: 0x002E338C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301006, XrefRangeEnd = 301018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x002E51C0 File Offset: 0x002E33C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301018, XrefRangeEnd = 301021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentViewer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x0005186E File Offset: 0x0004FA6E
		public DocumentViewer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600B163 RID: 45411 RVA: 0x002E51FC File Offset: 0x002E33FC
		// (set) Token: 0x0600B164 RID: 45412 RVA: 0x00051877 File Offset: 0x0004FA77
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600B165 RID: 45413 RVA: 0x002E5224 File Offset: 0x002E3424
		// (set) Token: 0x0600B166 RID: 45414 RVA: 0x00051892 File Offset: 0x0004FA92
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600B167 RID: 45415 RVA: 0x002E5254 File Offset: 0x002E3454
		// (set) Token: 0x0600B168 RID: 45416 RVA: 0x000518B1 File Offset: 0x0004FAB1
		public unsafe Il2CppReferenceArray<DocumentViewerPage> Documents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DocumentViewerPage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600B169 RID: 45417 RVA: 0x002E5284 File Offset: 0x002E3484
		// (set) Token: 0x0600B16A RID: 45418 RVA: 0x000518D0 File Offset: 0x0004FAD0
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600B16B RID: 45419 RVA: 0x002E52B4 File Offset: 0x002E34B4
		// (set) Token: 0x0600B16C RID: 45420 RVA: 0x000518EF File Offset: 0x0004FAEF
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A35 RID: 31285
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007A36 RID: 31286
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007A37 RID: 31287
		private static readonly IntPtr NativeFieldInfoPtr_Documents;

		// Token: 0x04007A38 RID: 31288
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04007A39 RID: 31289
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04007A3A RID: 31290
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007A3B RID: 31291
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007A3C RID: 31292
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007A3D RID: 31293
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x04007A3E RID: 31294
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007A3F RID: 31295
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04007A40 RID: 31296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
