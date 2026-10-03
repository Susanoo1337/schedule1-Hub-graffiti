using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200013F RID: 319
	[StructLayout(2)]
	public struct LayerMask
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x0006974C File Offset: 0x0006794C
		// Note: this type is marked as 'beforefieldinit'.
		static LayerMask()
		{
			Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LayerMask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
			LayerMask.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, "m_Mask");
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665894);
			LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665895);
			LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665896);
			LayerMask.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665897);
			LayerMask.NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665898);
			LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665899);
			LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100665900);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0006981C File Offset: 0x00067A1C
		[CallerCount(303)]
		[CachedScanResults(RefRangeStart = 1259146, RefRangeEnd = 1259449, XrefRangeStart = 1259146, XrefRangeEnd = 1259146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(LayerMask mask)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0006985C File Offset: 0x00067A5C
		[CallerCount(303)]
		[CachedScanResults(RefRangeStart = 1259146, RefRangeEnd = 1259449, XrefRangeStart = 1259146, XrefRangeEnd = 1259449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator LayerMask(int intVal)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0006989C File Offset: 0x00067A9C
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x000698CC File Offset: 0x00067ACC
		public unsafe int value
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00069900 File Offset: 0x00067B00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1259451, RefRangeEnd = 1259454, XrefRangeStart = 1259449, XrefRangeEnd = 1259451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string LayerToName(int layer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00069938 File Offset: 0x00067B38
		[CallerCount(91)]
		[CachedScanResults(RefRangeStart = 1259456, RefRangeEnd = 1259547, XrefRangeStart = 1259454, XrefRangeEnd = 1259456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NameToLayer(string layerName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(layerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0006997C File Offset: 0x00067B7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1259550, RefRangeEnd = 1259558, XrefRangeStart = 1259547, XrefRangeEnd = 1259550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMask([Optional] Il2CppStringArray layerNames)
		{
			if (layerNames == null)
			{
				layerNames = new Il2CppStringArray(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layerNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0000C2EA File Offset: 0x0000A4EA
		public static int GetMask(params string[] layerNames)
		{
			return LayerMask.GetMask(new Il2CppStringArray(layerNames));
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0000C2F7 File Offset: 0x0000A4F7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, ref this));
		}

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0;

		// Token: 0x040014A1 RID: 5281
		[FieldOffset(0)]
		public int m_Mask;
	}
}
