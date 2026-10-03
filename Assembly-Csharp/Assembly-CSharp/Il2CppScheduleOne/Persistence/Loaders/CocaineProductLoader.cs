using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001BC RID: 444
	public class CocaineProductLoader : Loader
	{
		// Token: 0x06002C19 RID: 11289 RVA: 0x0010D37C File Offset: 0x0010B57C
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductLoader()
		{
			Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CocaineProductLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr);
			CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668996);
			CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668997);
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x0010D3D4 File Offset: 0x0010B5D4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x0010D410 File Offset: 0x0010B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128408, XrefRangeEnd = 128425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00016D12 File Offset: 0x00014F12
		public CocaineProductLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
