using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000238 RID: 568
	[StructLayout(2)]
	public struct ShaderTagId
	{
		// Token: 0x060026F9 RID: 9977 RVA: 0x0009ACA0 File Offset: 0x00098EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderTagId()
		{
			Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShaderTagId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr);
			ShaderTagId.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "none");
			ShaderTagId.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, "m_Id");
			ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667502);
			ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667503);
			ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667504);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667505);
			ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667506);
			ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667507);
			ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667508);
			ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100667509);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0009AD98 File Offset: 0x00098F98
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1291777, RefRangeEnd = 1291818, XrefRangeStart = 1291776, XrefRangeEnd = 1291777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderTagId(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x0009ADD0 File Offset: 0x00098FD0
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x0009AE00 File Offset: 0x00099000
		public unsafe int id
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x0009AE34 File Offset: 0x00099034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291818, XrefRangeEnd = 1291821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x0009AE78 File Offset: 0x00099078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ShaderTagId other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x0009AEB8 File Offset: 0x000990B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291822, RefRangeEnd = 1291823, XrefRangeStart = 1291821, XrefRangeEnd = 1291822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x0009AEE8 File Offset: 0x000990E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1246094, RefRangeEnd = 1246100, XrefRangeStart = 1246094, XrefRangeEnd = 1246100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tag1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x0009AF34 File Offset: 0x00099134
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1286080, RefRangeEnd = 1286085, XrefRangeStart = 1286080, XrefRangeEnd = 1286085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tag1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tag2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000119D9 File Offset: 0x0000FBD9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, ref this));
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x0009AF80 File Offset: 0x00099180
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x000119EB File Offset: 0x0000FBEB
		public unsafe static ShaderTagId none
		{
			get
			{
				ShaderTagId result;
				IL2CPP.il2cpp_field_static_get_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderTagId.NativeFieldInfoPtr_none, (void*)(&value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x0009AF9C File Offset: 0x0009919C
		public string name
		{
			get
			{
				return Shader.IDToTag(this.id);
			}
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x0009AFBC File Offset: 0x000991BC
		public static explicit operator ShaderTagId(string name)
		{
			return new ShaderTagId(name);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x0009AFD4 File Offset: 0x000991D4
		public static explicit operator string(ShaderTagId tagId)
		{
			return tagId.name;
		}

		// Token: 0x0400214B RID: 8523
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Internal_get_Int32_0;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0;

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;

		// Token: 0x04002155 RID: 8533
		[FieldOffset(0)]
		public int m_Id;
	}
}
