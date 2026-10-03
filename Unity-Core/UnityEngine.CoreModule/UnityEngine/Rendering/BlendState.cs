using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021C RID: 540
	[StructLayout(2)]
	public struct BlendState
	{
		// Token: 0x060024B1 RID: 9393 RVA: 0x00092BE8 File Offset: 0x00090DE8
		// Note: this type is marked as 'beforefieldinit'.
		static BlendState()
		{
			Il2CppClassPointerStore<BlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BlendState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendState>.NativeClassPtr);
			BlendState.NativeFieldInfoPtr_m_BlendState0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState0");
			BlendState.NativeFieldInfoPtr_m_BlendState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState1");
			BlendState.NativeFieldInfoPtr_m_BlendState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState2");
			BlendState.NativeFieldInfoPtr_m_BlendState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState3");
			BlendState.NativeFieldInfoPtr_m_BlendState4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState4");
			BlendState.NativeFieldInfoPtr_m_BlendState5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState5");
			BlendState.NativeFieldInfoPtr_m_BlendState6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState6");
			BlendState.NativeFieldInfoPtr_m_BlendState7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_BlendState7");
			BlendState.NativeFieldInfoPtr_m_SeparateMRTBlendStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_SeparateMRTBlendStates");
			BlendState.NativeFieldInfoPtr_m_AlphaToMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_AlphaToMask");
			BlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, "m_Padding");
			BlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667226);
			BlendState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667227);
			BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667228);
			BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667229);
			BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667230);
			BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100667231);
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x00092D6C File Offset: 0x00090F6C
		public unsafe static BlendState defaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290119, RefRangeEnd = 1290120, XrefRangeStart = 1290118, XrefRangeEnd = 1290119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00092D9C File Offset: 0x00090F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290133, RefRangeEnd = 1290134, XrefRangeStart = 1290120, XrefRangeEnd = 1290133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendState(bool separateMRTBlend = false, bool alphaToMask = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref separateMRTBlend;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaToMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x00092F04 File Offset: 0x00091104
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x00092DDC File Offset: 0x00090FDC
		public unsafe RenderTargetBlendState blendState0
		{
			get
			{
				return this.m_BlendState0;
			}
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00092E10 File Offset: 0x00091010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290142, RefRangeEnd = 1290144, XrefRangeStart = 1290134, XrefRangeEnd = 1290142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BlendState other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00092E50 File Offset: 0x00091050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290144, XrefRangeEnd = 1290148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00092E94 File Offset: 0x00091094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290158, RefRangeEnd = 1290159, XrefRangeStart = 1290148, XrefRangeEnd = 1290158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x0001102D File Offset: 0x0000F22D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendState>.NativeClassPtr, ref this));
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x00092EC4 File Offset: 0x000910C4
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x0001103F File Offset: 0x0000F23F
		public bool separateMRTBlendStates
		{
			get
			{
				return Convert.ToBoolean(this.m_SeparateMRTBlendStates);
			}
			set
			{
				this.m_SeparateMRTBlendStates = Convert.ToByte(value);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x00092EE4 File Offset: 0x000910E4
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0001104E File Offset: 0x0000F24E
		public bool alphaToMask
		{
			get
			{
				return Convert.ToBoolean(this.m_AlphaToMask);
			}
			set
			{
				this.m_AlphaToMask = Convert.ToByte(value);
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x00092F1C File Offset: 0x0009111C
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0001105D File Offset: 0x0000F25D
		public RenderTargetBlendState blendState1
		{
			get
			{
				return this.m_BlendState1;
			}
			set
			{
				this.m_BlendState1 = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x00092F34 File Offset: 0x00091134
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x00011067 File Offset: 0x0000F267
		public RenderTargetBlendState blendState2
		{
			get
			{
				return this.m_BlendState2;
			}
			set
			{
				this.m_BlendState2 = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x00092F4C File Offset: 0x0009114C
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x00011071 File Offset: 0x0000F271
		public RenderTargetBlendState blendState3
		{
			get
			{
				return this.m_BlendState3;
			}
			set
			{
				this.m_BlendState3 = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x00092F64 File Offset: 0x00091164
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0001107B File Offset: 0x0000F27B
		public RenderTargetBlendState blendState4
		{
			get
			{
				return this.m_BlendState4;
			}
			set
			{
				this.m_BlendState4 = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x00092F7C File Offset: 0x0009117C
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x00011085 File Offset: 0x0000F285
		public RenderTargetBlendState blendState5
		{
			get
			{
				return this.m_BlendState5;
			}
			set
			{
				this.m_BlendState5 = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x00092F94 File Offset: 0x00091194
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0001108F File Offset: 0x0000F28F
		public RenderTargetBlendState blendState6
		{
			get
			{
				return this.m_BlendState6;
			}
			set
			{
				this.m_BlendState6 = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x00092FAC File Offset: 0x000911AC
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x00011099 File Offset: 0x0000F299
		public RenderTargetBlendState blendState7
		{
			get
			{
				return this.m_BlendState7;
			}
			set
			{
				this.m_BlendState7 = value;
			}
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00092FC4 File Offset: 0x000911C4
		public static bool operator ==(BlendState left, BlendState right)
		{
			return left.Equals(right);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00092FE0 File Offset: 0x000911E0
		public static bool operator !=(BlendState left, BlendState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState1;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState2;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState3;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState4;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState5;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState6;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState7;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeFieldInfoPtr_m_SeparateMRTBlendStates;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaToMask;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_BlendState_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001EEE RID: 7918
		[FieldOffset(0)]
		public RenderTargetBlendState m_BlendState0;

		// Token: 0x04001EEF RID: 7919
		[FieldOffset(8)]
		public RenderTargetBlendState m_BlendState1;

		// Token: 0x04001EF0 RID: 7920
		[FieldOffset(16)]
		public RenderTargetBlendState m_BlendState2;

		// Token: 0x04001EF1 RID: 7921
		[FieldOffset(24)]
		public RenderTargetBlendState m_BlendState3;

		// Token: 0x04001EF2 RID: 7922
		[FieldOffset(32)]
		public RenderTargetBlendState m_BlendState4;

		// Token: 0x04001EF3 RID: 7923
		[FieldOffset(40)]
		public RenderTargetBlendState m_BlendState5;

		// Token: 0x04001EF4 RID: 7924
		[FieldOffset(48)]
		public RenderTargetBlendState m_BlendState6;

		// Token: 0x04001EF5 RID: 7925
		[FieldOffset(56)]
		public RenderTargetBlendState m_BlendState7;

		// Token: 0x04001EF6 RID: 7926
		[FieldOffset(64)]
		public byte m_SeparateMRTBlendStates;

		// Token: 0x04001EF7 RID: 7927
		[FieldOffset(65)]
		public byte m_AlphaToMask;

		// Token: 0x04001EF8 RID: 7928
		[FieldOffset(66)]
		public short m_Padding;
	}
}
