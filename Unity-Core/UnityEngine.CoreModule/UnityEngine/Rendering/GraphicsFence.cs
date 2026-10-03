using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000204 RID: 516
	[StructLayout(2)]
	public struct GraphicsFence
	{
		// Token: 0x060021BB RID: 8635 RVA: 0x00088F54 File Offset: 0x00087154
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsFence()
		{
			Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsFence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr);
			GraphicsFence.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Ptr");
			GraphicsFence.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_Version");
			GraphicsFence.NativeFieldInfoPtr_m_FenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, "m_FenceType");
			GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100666997);
			GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100666998);
			GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100666999);
			GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667000);
			GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667001);
			GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100667002);
			GraphicsFence.HasFencePassed_InternalDelegateField = IL2CPP.ResolveICall<GraphicsFence.HasFencePassed_InternalDelegate>("UnityEngine.Rendering.GraphicsFence::HasFencePassed_Internal");
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00089048 File Offset: 0x00087248
		[CallerCount(0)]
		public unsafe static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00089088 File Offset: 0x00087288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1287947, RefRangeEnd = 1287949, XrefRangeStart = 1287944, XrefRangeEnd = 1287947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPostAllocation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000890B0 File Offset: 0x000872B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287949, XrefRangeEnd = 1287952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFencePending()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x000890E0 File Offset: 0x000872E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287953, RefRangeEnd = 1287954, XrefRangeStart = 1287952, XrefRangeEnd = 1287953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Validate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00089108 File Offset: 0x00087308
		[CallerCount(0)]
		public unsafe int GetPlatformNotSupportedVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00089138 File Offset: 0x00087338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287954, XrefRangeEnd = 1287956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetVersionNumber(IntPtr fencePtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fencePtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0000F6E2 File Offset: 0x0000D8E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, ref this));
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00089178 File Offset: 0x00087378
		public bool passed
		{
			get
			{
				this.Validate();
				bool flag = !SystemInfo.supportsGraphicsFence;
				if (flag)
				{
					throw new NotSupportedException("Cannot determine if this GraphicsFence has passed as this platform has not implemented GraphicsFences.");
				}
				bool flag2 = this.m_FenceType == GraphicsFenceType.AsyncQueueSynchronisation && !SystemInfo.supportsAsyncCompute;
				if (flag2)
				{
					throw new NotSupportedException("Cannot determine if this AsyncQueueSynchronisation GraphicsFence has passed as this platform does not support async compute.");
				}
				bool flag3 = !this.IsFencePending();
				return flag3 || GraphicsFence.HasFencePassed_Internal(this.m_Ptr);
			}
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0000F6F4 File Offset: 0x0000D8F4
		public static bool HasFencePassed_Internal(IntPtr fencePtr)
		{
			return GraphicsFence.HasFencePassed_InternalDelegateField(fencePtr);
		}

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeFieldInfoPtr_m_FenceType;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001CA0 RID: 7328
		[FieldOffset(0)]
		public IntPtr m_Ptr;

		// Token: 0x04001CA1 RID: 7329
		[FieldOffset(8)]
		public int m_Version;

		// Token: 0x04001CA2 RID: 7330
		[FieldOffset(12)]
		public GraphicsFenceType m_FenceType;

		// Token: 0x04001CA3 RID: 7331
		private static readonly GraphicsFence.HasFencePassed_InternalDelegate HasFencePassed_InternalDelegateField;

		// Token: 0x02000AD2 RID: 2770
		// (Invoke) Token: 0x06003E8D RID: 16013
		private delegate bool HasFencePassed_InternalDelegate(IntPtr fencePtr);
	}
}
