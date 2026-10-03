using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001EC RID: 492
	[StructLayout(2)]
	public struct SubMeshDescriptor
	{
		// Token: 0x06002180 RID: 8576 RVA: 0x00087DE4 File Offset: 0x00085FE4
		// Note: this type is marked as 'beforefieldinit'.
		static SubMeshDescriptor()
		{
			Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SubMeshDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr);
			SubMeshDescriptor.NativeFieldInfoPtr__bounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<bounds>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__topology_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<topology>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__indexStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexStart>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__indexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<indexCount>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__baseVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<baseVertex>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__firstVertex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<firstVertex>k__BackingField");
			SubMeshDescriptor.NativeFieldInfoPtr__vertexCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, "<vertexCount>k__BackingField");
			SubMeshDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666949);
			SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666950);
			SubMeshDescriptor.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666951);
			SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666952);
			SubMeshDescriptor.NativeMethodInfoPtr_set_topology_Public_set_Void_MeshTopology_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666953);
			SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666954);
			SubMeshDescriptor.NativeMethodInfoPtr_set_indexStart_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666955);
			SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666956);
			SubMeshDescriptor.NativeMethodInfoPtr_set_indexCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666957);
			SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666958);
			SubMeshDescriptor.NativeMethodInfoPtr_set_baseVertex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666959);
			SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666960);
			SubMeshDescriptor.NativeMethodInfoPtr_set_firstVertex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666961);
			SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666962);
			SubMeshDescriptor.NativeMethodInfoPtr_set_vertexCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666963);
			SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, 100666964);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00087FE0 File Offset: 0x000861E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287296, RefRangeEnd = 1287297, XrefRangeStart = 1287296, XrefRangeEnd = 1287296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = MeshTopology.Triangles)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref indexStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topology;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_MeshTopology_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x00088030 File Offset: 0x00086230
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x00088060 File Offset: 0x00086260
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00088094 File Offset: 0x00086294
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x000880C4 File Offset: 0x000862C4
		public unsafe MeshTopology topology
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_topology_Public_set_Void_MeshTopology_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x000880F8 File Offset: 0x000862F8
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x00088128 File Offset: 0x00086328
		public unsafe int indexStart
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_indexStart_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x0008815C File Offset: 0x0008635C
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x0008818C File Offset: 0x0008638C
		public unsafe int indexCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_indexCount_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000881C0 File Offset: 0x000863C0
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x000881F0 File Offset: 0x000863F0
		public unsafe int baseVertex
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_baseVertex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x00088224 File Offset: 0x00086424
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00088254 File Offset: 0x00086454
		public unsafe int firstVertex
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_firstVertex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00088288 File Offset: 0x00086488
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x000882B8 File Offset: 0x000864B8
		public unsafe int vertexCount
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165205, RefRangeEnd = 165206, XrefRangeStart = 165205, XrefRangeEnd = 165206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_set_vertexCount_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x000882EC File Offset: 0x000864EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287297, XrefRangeEnd = 1287334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubMeshDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0000F69E File Offset: 0x0000D89E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubMeshDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr__bounds_k__BackingField;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr__topology_k__BackingField;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr__indexStart_k__BackingField;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr__indexCount_k__BackingField;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr__baseVertex_k__BackingField;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr__firstVertex_k__BackingField;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeFieldInfoPtr__vertexCount_k__BackingField;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_MeshTopology_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_set_bounds_Public_set_Void_Bounds_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_get_topology_Public_get_MeshTopology_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_set_topology_Public_set_Void_MeshTopology_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_get_indexStart_Public_get_Int32_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_set_indexStart_Public_set_Void_Int32_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_get_indexCount_Public_get_Int32_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_set_indexCount_Public_set_Void_Int32_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_get_baseVertex_Public_get_Int32_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_set_baseVertex_Public_set_Void_Int32_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVertex_Public_get_Int32_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVertex_Public_set_Void_Int32_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexCount_Public_get_Int32_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexCount_Public_set_Void_Int32_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BCD RID: 7117
		[FieldOffset(0)]
		public Bounds _bounds_k__BackingField;

		// Token: 0x04001BCE RID: 7118
		[FieldOffset(24)]
		public MeshTopology _topology_k__BackingField;

		// Token: 0x04001BCF RID: 7119
		[FieldOffset(28)]
		public int _indexStart_k__BackingField;

		// Token: 0x04001BD0 RID: 7120
		[FieldOffset(32)]
		public int _indexCount_k__BackingField;

		// Token: 0x04001BD1 RID: 7121
		[FieldOffset(36)]
		public int _baseVertex_k__BackingField;

		// Token: 0x04001BD2 RID: 7122
		[FieldOffset(40)]
		public int _firstVertex_k__BackingField;

		// Token: 0x04001BD3 RID: 7123
		[FieldOffset(44)]
		public int _vertexCount_k__BackingField;
	}
}
