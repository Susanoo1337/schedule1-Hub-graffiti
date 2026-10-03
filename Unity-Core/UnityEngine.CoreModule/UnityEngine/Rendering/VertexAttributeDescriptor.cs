using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001ED RID: 493
	[StructLayout(2)]
	public struct VertexAttributeDescriptor
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x00088318 File Offset: 0x00086518
		// Note: this type is marked as 'beforefieldinit'.
		static VertexAttributeDescriptor()
		{
			Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VertexAttributeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr);
			VertexAttributeDescriptor.NativeFieldInfoPtr__attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<attribute>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<format>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__stream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<stream>k__BackingField");
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666965);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666966);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666967);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666968);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666969);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666970);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666971);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666972);
			VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666973);
			VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666974);
			VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666975);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666976);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100666977);
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x0008849C File Offset: 0x0008669C
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x000884CC File Offset: 0x000866CC
		public unsafe VertexAttribute attribute
		{
			[CallerCount(501)]
			[CachedScanResults(RefRangeStart = 40619, RefRangeEnd = 41120, XrefRangeStart = 40619, XrefRangeEnd = 41120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00088500 File Offset: 0x00086700
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00088530 File Offset: 0x00086730
		public unsafe VertexAttributeFormat format
		{
			[CallerCount(120)]
			[CachedScanResults(RefRangeStart = 54296, RefRangeEnd = 54416, XrefRangeStart = 54296, XrefRangeEnd = 54416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x00088564 File Offset: 0x00086764
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x00088594 File Offset: 0x00086794
		public unsafe int dimension
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 29148, RefRangeEnd = 29176, XrefRangeStart = 29148, XrefRangeEnd = 29176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29176, RefRangeEnd = 29187, XrefRangeStart = 29176, XrefRangeEnd = 29187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x000885C8 File Offset: 0x000867C8
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x000885F8 File Offset: 0x000867F8
		public unsafe int stream
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29187, RefRangeEnd = 29190, XrefRangeStart = 29187, XrefRangeEnd = 29190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29190, RefRangeEnd = 29194, XrefRangeStart = 29190, XrefRangeEnd = 29194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0008862C File Offset: 0x0008682C
		[CallerCount(276)]
		[CachedScanResults(RefRangeStart = 667373, RefRangeEnd = 667649, XrefRangeStart = 667373, XrefRangeEnd = 667649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref attribute;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00088688 File Offset: 0x00086888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287334, XrefRangeEnd = 1287359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000886B4 File Offset: 0x000868B4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000886E4 File Offset: 0x000868E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287359, XrefRangeEnd = 1287362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00088728 File Offset: 0x00086928
		[CallerCount(0)]
		public unsafe bool Equals(VertexAttributeDescriptor other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0000F6B0 File Offset: 0x0000D8B0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00088768 File Offset: 0x00086968
		public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00088784 File Offset: 0x00086984
		public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeFieldInfoPtr__attribute_k__BackingField;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeFieldInfoPtr__format_k__BackingField;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeFieldInfoPtr__stream_k__BackingField;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_get_Int32_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_get_stream_Public_get_Int32_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0;

		// Token: 0x04001BE5 RID: 7141
		[FieldOffset(0)]
		public VertexAttribute _attribute_k__BackingField;

		// Token: 0x04001BE6 RID: 7142
		[FieldOffset(4)]
		public VertexAttributeFormat _format_k__BackingField;

		// Token: 0x04001BE7 RID: 7143
		[FieldOffset(8)]
		public int _dimension_k__BackingField;

		// Token: 0x04001BE8 RID: 7144
		[FieldOffset(12)]
		public int _stream_k__BackingField;
	}
}
