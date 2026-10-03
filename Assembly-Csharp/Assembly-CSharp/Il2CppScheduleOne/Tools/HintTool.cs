using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E7 RID: 1255
	public class HintTool : MonoBehaviour
	{
		// Token: 0x06007222 RID: 29218 RVA: 0x00202628 File Offset: 0x00200828
		// Note: this type is marked as 'beforefieldinit'.
		static HintTool()
		{
			Il2CppClassPointerStore<HintTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "HintTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HintTool>.NativeClassPtr);
			HintTool.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintTool>.NativeClassPtr, 100678065);
			HintTool.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintTool>.NativeClassPtr, 100678066);
			HintTool.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintTool>.NativeClassPtr, 100678067);
			HintTool.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintTool>.NativeClassPtr, 100678068);
			HintTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HintTool>.NativeClassPtr, 100678069);
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x002026BC File Offset: 0x002008BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226187, XrefRangeEnd = 226192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_10s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintTool.NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x00202700 File Offset: 0x00200900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226192, XrefRangeEnd = 226197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHint_20s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintTool.NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x00202744 File Offset: 0x00200944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226197, XrefRangeEnd = 226203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_10s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintTool.NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x00202788 File Offset: 0x00200988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226203, XrefRangeEnd = 226209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueHint_20s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintTool.NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x002027CC File Offset: 0x002009CC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HintTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HintTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HintTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x000364A3 File Offset: 0x000346A3
		public HintTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004DF8 RID: 19960
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_10s_Public_Void_String_0;

		// Token: 0x04004DF9 RID: 19961
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_20s_Public_Void_String_0;

		// Token: 0x04004DFA RID: 19962
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_10s_Public_Void_String_0;

		// Token: 0x04004DFB RID: 19963
		private static readonly IntPtr NativeMethodInfoPtr_QueueHint_20s_Public_Void_String_0;

		// Token: 0x04004DFC RID: 19964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
