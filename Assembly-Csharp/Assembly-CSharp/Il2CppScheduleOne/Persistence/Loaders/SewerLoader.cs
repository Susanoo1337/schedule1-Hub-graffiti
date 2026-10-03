using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001CF RID: 463
	public class SewerLoader : Loader
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x0010EB60 File Offset: 0x0010CD60
		// Note: this type is marked as 'beforefieldinit'.
		static SewerLoader()
		{
			Il2CppClassPointerStore<SewerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "SewerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerLoader>.NativeClassPtr);
			SewerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerLoader>.NativeClassPtr, 100669063);
			SewerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerLoader>.NativeClassPtr, 100669064);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0010EBB8 File Offset: 0x0010CDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129746, XrefRangeEnd = 129767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0010EC08 File Offset: 0x0010CE08
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00016DBD File Offset: 0x00014FBD
		public SewerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
