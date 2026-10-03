using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000029 RID: 41
	public class CanvasSampleSaveFileText : MonoBehaviour
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x000819FC File Offset: 0x0007FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasSampleSaveFileText()
		{
			Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanvasSampleSaveFileText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr);
			CanvasSampleSaveFileText.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, "output");
			CanvasSampleSaveFileText.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, "_data");
			CanvasSampleSaveFileText.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, 100663548);
			CanvasSampleSaveFileText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, 100663549);
			CanvasSampleSaveFileText.NativeMethodInfoPtr_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, 100663550);
			CanvasSampleSaveFileText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr, 100663551);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00081AA4 File Offset: 0x0007FCA4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleSaveFileText.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00081AE8 File Offset: 0x0007FCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67376, XrefRangeEnd = 67387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleSaveFileText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00081B1C File Offset: 0x0007FD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67387, XrefRangeEnd = 67401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleSaveFileText.NativeMethodInfoPtr_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00081B50 File Offset: 0x0007FD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67401, XrefRangeEnd = 67406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasSampleSaveFileText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleSaveFileText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleSaveFileText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002F5A File Offset: 0x0000115A
		public CanvasSampleSaveFileText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00081B8C File Offset: 0x0007FD8C
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002F63 File Offset: 0x00001163
		public unsafe Text output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleSaveFileText.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleSaveFileText.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00081BBC File Offset: 0x0007FDBC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002F82 File Offset: 0x00001182
		public unsafe string _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleSaveFileText.NativeFieldInfoPtr__data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleSaveFileText.NativeFieldInfoPtr__data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Public_Void_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
