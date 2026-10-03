using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022C RID: 556
	[StructLayout(2)]
	public struct RendererList
	{
		// Token: 0x060025B2 RID: 9650 RVA: 0x0009627C File Offset: 0x0009447C
		// Note: this type is marked as 'beforefieldinit'.
		static RendererList()
		{
			Il2CppClassPointerStore<RendererList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RendererList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererList>.NativeClassPtr);
			RendererList.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "context");
			RendererList.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "index");
			RendererList.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "frame");
			RendererList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "type");
			RendererList.NativeFieldInfoPtr_nullRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "nullRendererList");
			RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100667330);
			RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100667331);
			RendererList.NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100667333);
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x0009634C File Offset: 0x0009454C
		public unsafe bool isValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1290591, RefRangeEnd = 1290594, XrefRangeStart = 1290586, XrefRangeEnd = 1290591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x0009637C File Offset: 0x0009457C
		[CallerCount(0)]
		public unsafe RendererList(UIntPtr ctx, uint indx)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ctx;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000963BC File Offset: 0x000945BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290594, XrefRangeEnd = 1290596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool get_isValid_Injected(ref RendererList _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000113A5 File Offset: 0x0000F5A5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererList>.NativeClassPtr, ref this));
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000963FC File Offset: 0x000945FC
		// (set) Token: 0x060025B8 RID: 9656 RVA: 0x000113B7 File Offset: 0x0000F5B7
		public unsafe static RendererList nullRendererList
		{
			get
			{
				RendererList result;
				IL2CPP.il2cpp_field_static_get_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*)(&value));
			}
		}

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr_nullRendererList;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0;

		// Token: 0x04002053 RID: 8275
		[FieldOffset(0)]
		public UIntPtr context;

		// Token: 0x04002054 RID: 8276
		[FieldOffset(8)]
		public uint index;

		// Token: 0x04002055 RID: 8277
		[FieldOffset(12)]
		public uint frame;

		// Token: 0x04002056 RID: 8278
		[FieldOffset(16)]
		public uint type;
	}
}
