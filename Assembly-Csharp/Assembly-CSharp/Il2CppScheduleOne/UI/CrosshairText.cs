using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000725 RID: 1829
	public class CrosshairText : MonoBehaviour
	{
		// Token: 0x0600B057 RID: 45143 RVA: 0x002E19D0 File Offset: 0x002DFBD0
		// Note: this type is marked as 'beforefieldinit'.
		static CrosshairText()
		{
			Il2CppClassPointerStore<CrosshairText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrosshairText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr);
			CrosshairText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "Label");
			CrosshairText.NativeFieldInfoPtr_setThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, "setThisFrame");
			CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100686488);
			CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100686489);
			CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100686490);
			CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100686491);
			CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr, 100686492);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x002E1A8C File Offset: 0x002DFC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x002E1AC0 File Offset: 0x002DFCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299951, XrefRangeEnd = 299952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x002E1AF4 File Offset: 0x002DFCF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 299955, RefRangeEnd = 299958, XrefRangeStart = 299952, XrefRangeEnd = 299955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(string text, Color col = default(Color))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Show_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x002E1B44 File Offset: 0x002DFD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x002E1B78 File Offset: 0x002DFD78
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrosshairText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrosshairText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrosshairText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x00050FB3 File Offset: 0x0004F1B3
		public CrosshairText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x002E1BB4 File Offset: 0x002DFDB4
		// (set) Token: 0x0600B05F RID: 45151 RVA: 0x00050FBC File Offset: 0x0004F1BC
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x002E1BE4 File Offset: 0x002DFDE4
		// (set) Token: 0x0600B061 RID: 45153 RVA: 0x00050FDB File Offset: 0x0004F1DB
		public unsafe bool setThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrosshairText.NativeFieldInfoPtr_setThisFrame)) = value;
			}
		}

		// Token: 0x0400798C RID: 31116
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400798D RID: 31117
		private static readonly IntPtr NativeFieldInfoPtr_setThisFrame;

		// Token: 0x0400798E RID: 31118
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400798F RID: 31119
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007990 RID: 31120
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_String_Color_0;

		// Token: 0x04007991 RID: 31121
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x04007992 RID: 31122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
