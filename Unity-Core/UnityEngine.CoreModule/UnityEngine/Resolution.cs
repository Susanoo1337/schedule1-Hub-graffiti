using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009F RID: 159
	[StructLayout(2)]
	public struct Resolution
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x00035DAC File Offset: 0x00033FAC
		// Note: this type is marked as 'beforefieldinit'.
		static Resolution()
		{
			Il2CppClassPointerStore<Resolution>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resolution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resolution>.NativeClassPtr);
			Resolution.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Width");
			Resolution.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_Height");
			Resolution.NativeFieldInfoPtr_m_RefreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Resolution>.NativeClassPtr, "m_RefreshRate");
			Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664279);
			Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664280);
			Resolution.NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664281);
			Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resolution>.NativeClassPtr, 100664282);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00035E68 File Offset: 0x00034068
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00006201 File Offset: 0x00004401
		public unsafe int width
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00035E98 File Offset: 0x00034098
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0000620B File Offset: 0x0000440B
		public unsafe int height
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1233024, RefRangeEnd = 1233045, XrefRangeStart = 1233024, XrefRangeEnd = 1233045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00035EC8 File Offset: 0x000340C8
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00006215 File Offset: 0x00004415
		public unsafe RefreshRate refreshRateRatio
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 537050, RefRangeEnd = 537070, XrefRangeStart = 537050, XrefRangeEnd = 537070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_RefreshRate = value;
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00035EF8 File Offset: 0x000340F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234495, XrefRangeEnd = 1234515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resolution.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000061EF File Offset: 0x000043EF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Resolution>.NativeClassPtr, ref this));
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00035F24 File Offset: 0x00034124
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0000621F File Offset: 0x0000441F
		public int refreshRate
		{
			get
			{
				return (int)Math.Round(this.m_RefreshRate.value);
			}
			set
			{
				this.m_RefreshRate.numerator = (uint)value;
				this.m_RefreshRate.denominator = 1U;
			}
		}

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshRate;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_refreshRateRatio_Public_get_RefreshRate_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400077F RID: 1919
		[FieldOffset(0)]
		public int m_Width;

		// Token: 0x04000780 RID: 1920
		[FieldOffset(4)]
		public int m_Height;

		// Token: 0x04000781 RID: 1921
		[FieldOffset(8)]
		public RefreshRate m_RefreshRate;
	}
}
