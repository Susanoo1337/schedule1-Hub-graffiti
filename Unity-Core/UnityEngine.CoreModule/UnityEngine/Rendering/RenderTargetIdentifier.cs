using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001EF RID: 495
	[StructLayout(2)]
	public struct RenderTargetIdentifier
	{
		// Token: 0x060021A3 RID: 8611 RVA: 0x000887A4 File Offset: 0x000869A4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetIdentifier()
		{
			Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
			RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "AllDepthSlices");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_Type");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_NameID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_InstanceID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_BufferPointer");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_MipLevel");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_CubeFace");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_DepthSlice");
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666978);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666979);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666980);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666981);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666982);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666983);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666984);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666985);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666986);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666987);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666988);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666989);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666990);
			RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666991);
			RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666992);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666993);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666994);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666995);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100666996);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x000889F0 File Offset: 0x00086BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287362, RefRangeEnd = 1287363, XrefRangeStart = 1287362, XrefRangeEnd = 1287362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00088A24 File Offset: 0x00086C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287363, XrefRangeEnd = 1287364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00088A5C File Offset: 0x00086C5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1287365, RefRangeEnd = 1287368, XrefRangeStart = 1287364, XrefRangeEnd = 1287365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(string name, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00088ABC File Offset: 0x00086CBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1287368, RefRangeEnd = 1287371, XrefRangeStart = 1287368, XrefRangeEnd = 1287368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(int nameID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00088AF0 File Offset: 0x00086CF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1287371, RefRangeEnd = 1287377, XrefRangeStart = 1287371, XrefRangeEnd = 1287371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00088B4C File Offset: 0x00086D4C
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 1287377, RefRangeEnd = 1287440, XrefRangeStart = 1287377, XrefRangeEnd = 1287377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref renderTargetIdentifier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00088BA8 File Offset: 0x00086DA8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1287453, RefRangeEnd = 1287462, XrefRangeStart = 1287440, XrefRangeEnd = 1287453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(Texture tex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00088BE0 File Offset: 0x00086DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287462, XrefRangeEnd = 1287475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(Texture tex, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00088C40 File Offset: 0x00086E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287475, RefRangeEnd = 1287476, XrefRangeStart = 1287475, XrefRangeEnd = 1287475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buf;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00088C9C File Offset: 0x00086E9C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1287476, RefRangeEnd = 1287526, XrefRangeStart = 1287476, XrefRangeEnd = 1287476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00088CDC File Offset: 0x00086EDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1287527, RefRangeEnd = 1287529, XrefRangeStart = 1287526, XrefRangeEnd = 1287527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00088D20 File Offset: 0x00086F20
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1287529, RefRangeEnd = 1287749, XrefRangeStart = 1287529, XrefRangeEnd = 1287529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(int nameID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00088D60 File Offset: 0x00086F60
		[CallerCount(85)]
		[CachedScanResults(RefRangeStart = 1287762, RefRangeEnd = 1287847, XrefRangeStart = 1287749, XrefRangeEnd = 1287762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(Texture tex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00088DA4 File Offset: 0x00086FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287847, XrefRangeEnd = 1287885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00088DD0 File Offset: 0x00086FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1287888, RefRangeEnd = 1287889, XrefRangeStart = 1287885, XrefRangeEnd = 1287888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00088E00 File Offset: 0x00087000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287889, XrefRangeEnd = 1287890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetIdentifier rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00088E40 File Offset: 0x00087040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287890, XrefRangeEnd = 1287894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00088E84 File Offset: 0x00087084
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1287895, RefRangeEnd = 1287918, XrefRangeStart = 1287894, XrefRangeEnd = 1287895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00088ED0 File Offset: 0x000870D0
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1287919, RefRangeEnd = 1287944, XrefRangeStart = 1287918, XrefRangeEnd = 1287919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, ref this));
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00088F1C File Offset: 0x0008711C
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		public unsafe static int AllDepthSlices
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&value));
			}
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00088F38 File Offset: 0x00087138
		public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
		{
			return new RenderTargetIdentifier(buf, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeFieldInfoPtr_AllDepthSlices;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeFieldInfoPtr_m_NameID;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPointer;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr_m_MipLevel;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr_m_CubeFace;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthSlice;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_CubemapFace_Int32_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04001C0B RID: 7179
		[FieldOffset(0)]
		public BuiltinRenderTextureType m_Type;

		// Token: 0x04001C0C RID: 7180
		[FieldOffset(4)]
		public int m_NameID;

		// Token: 0x04001C0D RID: 7181
		[FieldOffset(8)]
		public int m_InstanceID;

		// Token: 0x04001C0E RID: 7182
		[FieldOffset(16)]
		public IntPtr m_BufferPointer;

		// Token: 0x04001C0F RID: 7183
		[FieldOffset(24)]
		public int m_MipLevel;

		// Token: 0x04001C10 RID: 7184
		[FieldOffset(28)]
		public CubemapFace m_CubeFace;

		// Token: 0x04001C11 RID: 7185
		[FieldOffset(32)]
		public int m_DepthSlice;
	}
}
