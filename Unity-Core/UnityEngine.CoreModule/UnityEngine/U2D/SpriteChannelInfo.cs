using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x0200017A RID: 378
	[StructLayout(2)]
	public struct SpriteChannelInfo
	{
		// Token: 0x06001D25 RID: 7461 RVA: 0x0007871C File Offset: 0x0007691C
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteChannelInfo()
		{
			Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteChannelInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr);
			SpriteChannelInfo.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Buffer");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Count");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Offset");
			SpriteChannelInfo.NativeFieldInfoPtr_m_Stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Stride");
			SpriteChannelInfo.NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100666435);
			SpriteChannelInfo.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100666436);
			SpriteChannelInfo.NativeMethodInfoPtr_get_offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100666437);
			SpriteChannelInfo.NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100666438);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000787EC File Offset: 0x000769EC
		// (set) Token: 0x06001D2B RID: 7467 RVA: 0x0000DB68 File Offset: 0x0000BD68
		public unsafe void* buffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282225, RefRangeEnd = 1282226, XrefRangeStart = 1282224, XrefRangeEnd = 1282225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr result = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0, ref this, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return result;
			}
			set
			{
				this.m_Buffer = (IntPtr)value;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00078814 File Offset: 0x00076A14
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000DB77 File Offset: 0x0000BD77
		public unsafe int count
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Count = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00078844 File Offset: 0x00076A44
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x0000DB81 File Offset: 0x0000BD81
		public unsafe int offset
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 1225947, RefRangeEnd = 1226040, XrefRangeStart = 1225947, XrefRangeEnd = 1226040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_offset_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Offset = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00078874 File Offset: 0x00076A74
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000DB8B File Offset: 0x0000BD8B
		public unsafe int stride
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 669546, RefRangeEnd = 669595, XrefRangeStart = 669546, XrefRangeEnd = 669595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteChannelInfo.NativeMethodInfoPtr_get_stride_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Stride = value;
			}
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0000DB56 File Offset: 0x0000BD56
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_m_Stride;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeMethodInfoPtr_get_offset_Public_get_Int32_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

		// Token: 0x040017F7 RID: 6135
		[FieldOffset(0)]
		public IntPtr m_Buffer;

		// Token: 0x040017F8 RID: 6136
		[FieldOffset(8)]
		public int m_Count;

		// Token: 0x040017F9 RID: 6137
		[FieldOffset(12)]
		public int m_Offset;

		// Token: 0x040017FA RID: 6138
		[FieldOffset(16)]
		public int m_Stride;
	}
}
