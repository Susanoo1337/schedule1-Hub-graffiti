using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000236 RID: 566
	[StructLayout(2)]
	public struct RenderTargetBlendState
	{
		// Token: 0x06002678 RID: 9848 RVA: 0x00098D00 File Offset: 0x00096F00
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetBlendState()
		{
			Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetBlendState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr);
			RenderTargetBlendState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_WriteMask");
			RenderTargetBlendState.NativeFieldInfoPtr_m_SourceColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceColorBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationColorBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_SourceAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_SourceAlphaBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_DestinationAlphaBlendMode");
			RenderTargetBlendState.NativeFieldInfoPtr_m_ColorBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_ColorBlendOperation");
			RenderTargetBlendState.NativeFieldInfoPtr_m_AlphaBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_AlphaBlendOperation");
			RenderTargetBlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, "m_Padding");
			RenderTargetBlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100667427);
			RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100667428);
			RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100667429);
			RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100667430);
			RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100667431);
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x00098E34 File Offset: 0x00097034
		public unsafe static RenderTargetBlendState defaultValue
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1291194, RefRangeEnd = 1291202, XrefRangeStart = 1291194, XrefRangeEnd = 1291194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00098E64 File Offset: 0x00097064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291202, RefRangeEnd = 1291203, XrefRangeStart = 1291202, XrefRangeEnd = 1291202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetBlendState(ColorWriteMask writeMask = ColorWriteMask.All, BlendMode sourceColorBlendMode = BlendMode.One, BlendMode destinationColorBlendMode = BlendMode.Zero, BlendMode sourceAlphaBlendMode = BlendMode.One, BlendMode destinationAlphaBlendMode = BlendMode.Zero, BlendOp colorBlendOperation = BlendOp.Add, BlendOp alphaBlendOperation = BlendOp.Add)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref writeMask;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceColorBlendMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationColorBlendMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceAlphaBlendMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationAlphaBlendMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBlendOperation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alphaBlendOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00098EEC File Offset: 0x000970EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1291203, RefRangeEnd = 1291211, XrefRangeStart = 1291203, XrefRangeEnd = 1291203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetBlendState other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00098F2C File Offset: 0x0009712C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291211, XrefRangeEnd = 1291214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00098F70 File Offset: 0x00097170
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1291221, RefRangeEnd = 1291229, XrefRangeStart = 1291214, XrefRangeEnd = 1291221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000117BE File Offset: 0x0000F9BE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, ref this));
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00098FA0 File Offset: 0x000971A0
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x000117D0 File Offset: 0x0000F9D0
		public ColorWriteMask writeMask
		{
			get
			{
				return (ColorWriteMask)this.m_WriteMask;
			}
			set
			{
				this.m_WriteMask = (byte)value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x00098FB8 File Offset: 0x000971B8
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x000117DB File Offset: 0x0000F9DB
		public BlendMode sourceColorBlendMode
		{
			get
			{
				return (BlendMode)this.m_SourceColorBlendMode;
			}
			set
			{
				this.m_SourceColorBlendMode = (byte)value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x00098FD0 File Offset: 0x000971D0
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x000117E6 File Offset: 0x0000F9E6
		public BlendMode destinationColorBlendMode
		{
			get
			{
				return (BlendMode)this.m_DestinationColorBlendMode;
			}
			set
			{
				this.m_DestinationColorBlendMode = (byte)value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x00098FE8 File Offset: 0x000971E8
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x000117F1 File Offset: 0x0000F9F1
		public BlendMode sourceAlphaBlendMode
		{
			get
			{
				return (BlendMode)this.m_SourceAlphaBlendMode;
			}
			set
			{
				this.m_SourceAlphaBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x00099000 File Offset: 0x00097200
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x000117FC File Offset: 0x0000F9FC
		public BlendMode destinationAlphaBlendMode
		{
			get
			{
				return (BlendMode)this.m_DestinationAlphaBlendMode;
			}
			set
			{
				this.m_DestinationAlphaBlendMode = (byte)value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x00099018 File Offset: 0x00097218
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x00011807 File Offset: 0x0000FA07
		public BlendOp colorBlendOperation
		{
			get
			{
				return (BlendOp)this.m_ColorBlendOperation;
			}
			set
			{
				this.m_ColorBlendOperation = (byte)value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x00099030 File Offset: 0x00097230
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x00011812 File Offset: 0x0000FA12
		public BlendOp alphaBlendOperation
		{
			get
			{
				return (BlendOp)this.m_AlphaBlendOperation;
			}
			set
			{
				this.m_AlphaBlendOperation = (byte)value;
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00099048 File Offset: 0x00097248
		public static bool operator ==(RenderTargetBlendState left, RenderTargetBlendState right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00099064 File Offset: 0x00097264
		public static bool operator !=(RenderTargetBlendState left, RenderTargetBlendState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteMask;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceColorBlendMode;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_m_DestinationColorBlendMode;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceAlphaBlendMode;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_m_DestinationAlphaBlendMode;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorBlendOperation;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaBlendOperation;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_RenderTargetBlendState_0;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020F6 RID: 8438
		[FieldOffset(0)]
		public byte m_WriteMask;

		// Token: 0x040020F7 RID: 8439
		[FieldOffset(1)]
		public byte m_SourceColorBlendMode;

		// Token: 0x040020F8 RID: 8440
		[FieldOffset(2)]
		public byte m_DestinationColorBlendMode;

		// Token: 0x040020F9 RID: 8441
		[FieldOffset(3)]
		public byte m_SourceAlphaBlendMode;

		// Token: 0x040020FA RID: 8442
		[FieldOffset(4)]
		public byte m_DestinationAlphaBlendMode;

		// Token: 0x040020FB RID: 8443
		[FieldOffset(5)]
		public byte m_ColorBlendOperation;

		// Token: 0x040020FC RID: 8444
		[FieldOffset(6)]
		public byte m_AlphaBlendOperation;

		// Token: 0x040020FD RID: 8445
		[FieldOffset(7)]
		public byte m_Padding;
	}
}
