using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000024 RID: 36
	public class BasicSample : MonoBehaviour
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x00080ED8 File Offset: 0x0007F0D8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicSample()
		{
			Il2CppClassPointerStore<BasicSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasicSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicSample>.NativeClassPtr);
			BasicSample.NativeFieldInfoPtr__path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, "_path");
			BasicSample.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663503);
			BasicSample.NativeMethodInfoPtr_WriteResult_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663504);
			BasicSample.NativeMethodInfoPtr_WriteResult_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663505);
			BasicSample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663506);
			BasicSample.NativeMethodInfoPtr__OnGUI_b__1_0_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663507);
			BasicSample.NativeMethodInfoPtr__OnGUI_b__1_1_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663508);
			BasicSample.NativeMethodInfoPtr__OnGUI_b__1_2_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicSample>.NativeClassPtr, 100663509);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00080FA8 File Offset: 0x0007F1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66845, XrefRangeEnd = 67147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00080FDC File Offset: 0x0007F1DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 67156, RefRangeEnd = 67165, XrefRangeStart = 67147, XrefRangeEnd = 67156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteResult(Il2CppStringArray paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr_WriteResult_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00081020 File Offset: 0x0007F220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteResult(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr_WriteResult_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00081064 File Offset: 0x0007F264
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicSample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicSample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000810A0 File Offset: 0x0007F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67165, XrefRangeEnd = 67166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGUI_b__1_0(Il2CppStringArray paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr__OnGUI_b__1_0_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000810E4 File Offset: 0x0007F2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGUI_b__1_1(Il2CppStringArray paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr__OnGUI_b__1_1_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00081128 File Offset: 0x0007F328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGUI_b__1_2(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicSample.NativeMethodInfoPtr__OnGUI_b__1_2_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002E73 File Offset: 0x00001073
		public BasicSample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0008116C File Offset: 0x0007F36C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002E7C File Offset: 0x0000107C
		public unsafe string _path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicSample.NativeFieldInfoPtr__path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicSample.NativeFieldInfoPtr__path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr__path;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_WriteResult_Public_Void_Il2CppStringArray_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_WriteResult_Public_Void_String_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr__OnGUI_b__1_0_Private_Void_Il2CppStringArray_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr__OnGUI_b__1_1_Private_Void_Il2CppStringArray_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__OnGUI_b__1_2_Private_Void_String_0;
	}
}
