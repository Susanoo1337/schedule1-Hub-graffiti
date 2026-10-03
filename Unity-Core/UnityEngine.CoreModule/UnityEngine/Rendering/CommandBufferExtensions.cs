using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000208 RID: 520
	public static class CommandBufferExtensions : Object
	{
		// Token: 0x060023EF RID: 9199 RVA: 0x000905A0 File Offset: 0x0008E7A0
		// Note: this type is marked as 'beforefieldinit'.
		static CommandBufferExtensions()
		{
			Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CommandBufferExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr);
			CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100667184);
			CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100667185);
			CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100667186);
			CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100667187);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00090620 File Offset: 0x0008E820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289879, XrefRangeEnd = 1289881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fastMemoryFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00090690 File Offset: 0x0008E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289881, XrefRangeEnd = 1289883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000906E4 File Offset: 0x0008E8E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1289885, RefRangeEnd = 1289887, XrefRangeStart = 1289883, XrefRangeEnd = 1289885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwitchIntoFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fastMemoryFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref residency;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00090754 File Offset: 0x0008E954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289889, RefRangeEnd = 1289890, XrefRangeStart = 1289887, XrefRangeEnd = 1289889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwitchOutOfFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyContents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x000109D7 File Offset: 0x0000EBD7
		public CommandBufferExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0;
	}
}
