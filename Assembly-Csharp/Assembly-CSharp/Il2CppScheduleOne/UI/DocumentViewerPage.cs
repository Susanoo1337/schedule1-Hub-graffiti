using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200072E RID: 1838
	public class DocumentViewerPage : MonoBehaviour
	{
		// Token: 0x0600B16D RID: 45421 RVA: 0x002E52E4 File Offset: 0x002E34E4
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentViewerPage()
		{
			Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DocumentViewerPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr);
			DocumentViewerPage.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr, "Name");
			DocumentViewerPage.NativeFieldInfoPtr_OnPageViewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr, "OnPageViewed");
			DocumentViewerPage.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr, 100686627);
			DocumentViewerPage.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr, 100686628);
			DocumentViewerPage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr, 100686629);
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x002E5378 File Offset: 0x002E3578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301024, RefRangeEnd = 301025, XrefRangeStart = 301021, XrefRangeEnd = 301024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewerPage.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x002E53AC File Offset: 0x002E35AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187975, RefRangeEnd = 187977, XrefRangeStart = 187975, XrefRangeEnd = 187977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewerPage.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x002E53E0 File Offset: 0x002E35E0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentViewerPage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentViewerPage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewerPage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x0005190E File Offset: 0x0004FB0E
		public DocumentViewerPage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600B172 RID: 45426 RVA: 0x002E541C File Offset: 0x002E361C
		// (set) Token: 0x0600B173 RID: 45427 RVA: 0x00051917 File Offset: 0x0004FB17
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewerPage.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewerPage.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600B174 RID: 45428 RVA: 0x002E5444 File Offset: 0x002E3644
		// (set) Token: 0x0600B175 RID: 45429 RVA: 0x00051936 File Offset: 0x0004FB36
		public unsafe UnityEvent OnPageViewed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewerPage.NativeFieldInfoPtr_OnPageViewed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewerPage.NativeFieldInfoPtr_OnPageViewed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A41 RID: 31297
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04007A42 RID: 31298
		private static readonly IntPtr NativeFieldInfoPtr_OnPageViewed;

		// Token: 0x04007A43 RID: 31299
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007A44 RID: 31300
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007A45 RID: 31301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
