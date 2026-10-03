using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021B RID: 539
	[StructLayout(2)]
	public struct AttachmentDescriptor
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x0009261C File Offset: 0x0009081C
		// Note: this type is marked as 'beforefieldinit'.
		static AttachmentDescriptor()
		{
			Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AttachmentDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr);
			AttachmentDescriptor.NativeFieldInfoPtr_m_LoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadAction");
			AttachmentDescriptor.NativeFieldInfoPtr_m_StoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_StoreAction");
			AttachmentDescriptor.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_Format");
			AttachmentDescriptor.NativeFieldInfoPtr_m_LoadStoreTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadStoreTarget");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ResolveTarget");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearColor");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearDepth");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearStencil");
			AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667213);
			AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667214);
			AttachmentDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667215);
			AttachmentDescriptor.NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667216);
			AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667217);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667218);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667219);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667220);
			AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667221);
			AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667222);
			AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667223);
			AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667224);
			AttachmentDescriptor.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100667225);
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x00092AF4 File Offset: 0x00090CF4
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x000927F0 File Offset: 0x000909F0
		public unsafe RenderBufferLoadAction loadAction
		{
			get
			{
				return this.m_LoadAction;
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x00092B0C File Offset: 0x00090D0C
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x00092824 File Offset: 0x00090A24
		public unsafe RenderBufferStoreAction storeAction
		{
			get
			{
				return this.m_StoreAction;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00092858 File Offset: 0x00090A58
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00010FEB File Offset: 0x0000F1EB
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Format = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x00092888 File Offset: 0x00090A88
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x000928B8 File Offset: 0x00090AB8
		public unsafe RenderTargetIdentifier loadStoreTarget
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1290070, RefRangeEnd = 1290074, XrefRangeStart = 1290070, XrefRangeEnd = 1290070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290074, RefRangeEnd = 1290076, XrefRangeStart = 1290074, XrefRangeEnd = 1290074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000928EC File Offset: 0x00090AEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290076, RefRangeEnd = 1290080, XrefRangeStart = 1290076, XrefRangeEnd = 1290076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExistingContents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeResults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0009293C File Offset: 0x00090B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290080, RefRangeEnd = 1290082, XrefRangeStart = 1290080, XrefRangeEnd = 1290080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureResolveTarget(RenderTargetIdentifier target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00092970 File Offset: 0x00090B70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290082, RefRangeEnd = 1290086, XrefRangeStart = 1290082, XrefRangeEnd = 1290082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureClear(Color clearColor, float clearDepth = 1f, uint clearStencil = 0U)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref clearColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearStencil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x000929C0 File Offset: 0x00090BC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1290086, RefRangeEnd = 1290091, XrefRangeStart = 1290086, XrefRangeEnd = 1290086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000929F4 File Offset: 0x00090BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290099, RefRangeEnd = 1290101, XrefRangeStart = 1290091, XrefRangeEnd = 1290099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AttachmentDescriptor other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00092A34 File Offset: 0x00090C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290101, XrefRangeEnd = 1290105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00092A78 File Offset: 0x00090C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290105, XrefRangeEnd = 1290116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00092AA8 File Offset: 0x00090CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290117, RefRangeEnd = 1290118, XrefRangeStart = 1290116, XrefRangeEnd = 1290117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00010FD9 File Offset: 0x0000F1D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x00092B24 File Offset: 0x00090D24
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00010FF5 File Offset: 0x0000F1F5
		public RenderTextureFormat format
		{
			get
			{
				bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsDepthStencilFormat(this.m_Format) && this.m_Format != UnityEngine.Experimental.Rendering.GraphicsFormat.ShadowAuto;
				RenderTextureFormat result;
				if (flag)
				{
					result = RenderTextureFormat.Depth;
				}
				else
				{
					result = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(this.m_Format);
				}
				return result;
			}
			set
			{
				this.m_Format = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, RenderTextureReadWrite.Default);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00092B6C File Offset: 0x00090D6C
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00011005 File Offset: 0x0000F205
		public RenderTargetIdentifier resolveTarget
		{
			get
			{
				return this.m_ResolveTarget;
			}
			set
			{
				this.m_ResolveTarget = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x00092B84 File Offset: 0x00090D84
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0001100F File Offset: 0x0000F20F
		public Color clearColor
		{
			get
			{
				return this.m_ClearColor;
			}
			set
			{
				this.m_ClearColor = value;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x00092B9C File Offset: 0x00090D9C
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x00011019 File Offset: 0x0000F219
		public float clearDepth
		{
			get
			{
				return this.m_ClearDepth;
			}
			set
			{
				this.m_ClearDepth = value;
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x00092BB4 File Offset: 0x00090DB4
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x00011023 File Offset: 0x0000F223
		public uint clearStencil
		{
			get
			{
				return this.m_ClearStencil;
			}
			set
			{
				this.m_ClearStencil = value;
			}
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00092BCC File Offset: 0x00090DCC
		public static bool operator ==(AttachmentDescriptor left, AttachmentDescriptor right)
		{
			return left.Equals(right);
		}

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadAction;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreAction;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeFieldInfoPtr_m_Format;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadStoreTarget;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolveTarget;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearColor;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDepth;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearStencil;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0;

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0;

		// Token: 0x04001ED5 RID: 7893
		[FieldOffset(0)]
		public RenderBufferLoadAction m_LoadAction;

		// Token: 0x04001ED6 RID: 7894
		[FieldOffset(4)]
		public RenderBufferStoreAction m_StoreAction;

		// Token: 0x04001ED7 RID: 7895
		[FieldOffset(8)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;

		// Token: 0x04001ED8 RID: 7896
		[FieldOffset(16)]
		public RenderTargetIdentifier m_LoadStoreTarget;

		// Token: 0x04001ED9 RID: 7897
		[FieldOffset(56)]
		public RenderTargetIdentifier m_ResolveTarget;

		// Token: 0x04001EDA RID: 7898
		[FieldOffset(96)]
		public Color m_ClearColor;

		// Token: 0x04001EDB RID: 7899
		[FieldOffset(112)]
		public float m_ClearDepth;

		// Token: 0x04001EDC RID: 7900
		[FieldOffset(116)]
		public uint m_ClearStencil;
	}
}
