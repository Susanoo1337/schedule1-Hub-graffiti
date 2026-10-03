using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022A RID: 554
	[StructLayout(2)]
	public struct RasterState
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x00095F6C File Offset: 0x0009416C
		// Note: this type is marked as 'beforefieldinit'.
		static RasterState()
		{
			Il2CppClassPointerStore<RasterState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RasterState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RasterState>.NativeClassPtr);
			RasterState.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "defaultValue");
			RasterState.NativeFieldInfoPtr_m_CullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_CullingMode");
			RasterState.NativeFieldInfoPtr_m_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetUnits");
			RasterState.NativeFieldInfoPtr_m_OffsetFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_OffsetFactor");
			RasterState.NativeFieldInfoPtr_m_DepthClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_DepthClip");
			RasterState.NativeFieldInfoPtr_m_Conservative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Conservative");
			RasterState.NativeFieldInfoPtr_m_Padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding1");
			RasterState.NativeFieldInfoPtr_m_Padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, "m_Padding2");
			RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100667325);
			RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100667326);
			RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100667327);
			RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100667328);
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x0009608C File Offset: 0x0009428C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290577, RefRangeEnd = 1290578, XrefRangeStart = 1290572, XrefRangeEnd = 1290577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RasterState(CullMode cullingMode = CullMode.Back, int offsetUnits = 0, float offsetFactor = 0f, bool depthClip = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetUnits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetFactor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthClip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000960E8 File Offset: 0x000942E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290579, RefRangeEnd = 1290580, XrefRangeStart = 1290578, XrefRangeEnd = 1290579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RasterState other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00096128 File Offset: 0x00094328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290580, XrefRangeEnd = 1290582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0009616C File Offset: 0x0009436C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290585, RefRangeEnd = 1290586, XrefRangeStart = 1290582, XrefRangeEnd = 1290585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00011349 File Offset: 0x0000F549
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RasterState>.NativeClassPtr, ref this));
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x0009619C File Offset: 0x0009439C
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0001135B File Offset: 0x0000F55B
		public unsafe static RasterState defaultValue
		{
			get
			{
				RasterState result;
				IL2CPP.il2cpp_field_static_get_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*)(&value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000961B8 File Offset: 0x000943B8
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x00011369 File Offset: 0x0000F569
		public CullMode cullingMode
		{
			get
			{
				return this.m_CullingMode;
			}
			set
			{
				this.m_CullingMode = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000961D0 File Offset: 0x000943D0
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00011373 File Offset: 0x0000F573
		public bool depthClip
		{
			get
			{
				return Convert.ToBoolean(this.m_DepthClip);
			}
			set
			{
				this.m_DepthClip = Convert.ToByte(value);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000961F0 File Offset: 0x000943F0
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00011382 File Offset: 0x0000F582
		public bool conservative
		{
			get
			{
				return Convert.ToBoolean(this.m_Conservative);
			}
			set
			{
				this.m_Conservative = Convert.ToByte(value);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00096210 File Offset: 0x00094410
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x00011391 File Offset: 0x0000F591
		public int offsetUnits
		{
			get
			{
				return this.m_OffsetUnits;
			}
			set
			{
				this.m_OffsetUnits = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x00096228 File Offset: 0x00094428
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0001139B File Offset: 0x0000F59B
		public float offsetFactor
		{
			get
			{
				return this.m_OffsetFactor;
			}
			set
			{
				this.m_OffsetFactor = value;
			}
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00096240 File Offset: 0x00094440
		public static bool operator ==(RasterState left, RasterState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0009625C File Offset: 0x0009445C
		public static bool operator !=(RasterState left, RasterState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMode;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetUnits;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_m_OffsetFactor;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthClip;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_m_Conservative;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding1;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding2;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400203F RID: 8255
		[FieldOffset(0)]
		public CullMode m_CullingMode;

		// Token: 0x04002040 RID: 8256
		[FieldOffset(4)]
		public int m_OffsetUnits;

		// Token: 0x04002041 RID: 8257
		[FieldOffset(8)]
		public float m_OffsetFactor;

		// Token: 0x04002042 RID: 8258
		[FieldOffset(12)]
		public byte m_DepthClip;

		// Token: 0x04002043 RID: 8259
		[FieldOffset(13)]
		public byte m_Conservative;

		// Token: 0x04002044 RID: 8260
		[FieldOffset(14)]
		public byte m_Padding1;

		// Token: 0x04002045 RID: 8261
		[FieldOffset(15)]
		public byte m_Padding2;
	}
}
