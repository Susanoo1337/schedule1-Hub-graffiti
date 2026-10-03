using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x02000194 RID: 404
	public class UnityEventTools : Object
	{
		// Token: 0x06001E87 RID: 7815 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventTools()
		{
			Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventTools");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
			UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100666585);
			UnityEventTools.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100666586);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0007C228 File Offset: 0x0007A428
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1282724, RefRangeEnd = 1282737, XrefRangeStart = 1282693, XrefRangeEnd = 1282724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TidyAssemblyTypeName(string assemblyTypeName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0007C264 File Offset: 0x0007A464
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventTools() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0000E592 File Offset: 0x0000C792
		public UnityEventTools(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
