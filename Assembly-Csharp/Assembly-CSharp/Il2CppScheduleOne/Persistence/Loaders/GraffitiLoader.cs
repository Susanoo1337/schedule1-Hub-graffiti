using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001C1 RID: 449
	public class GraffitiLoader : Loader
	{
		// Token: 0x06002C31 RID: 11313 RVA: 0x0010D998 File Offset: 0x0010BB98
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiLoader()
		{
			Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "GraffitiLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr);
			GraffitiLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr, 100669010);
			GraffitiLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr, 100669011);
			GraffitiLoader.NativeMethodInfoPtr_LoadSpraySurface_Private_Void_WorldSpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr, 100669012);
			GraffitiLoader.NativeMethodInfoPtr_EnsureStrokesHaveValidSize_Private_Void_SpraySurfaceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr, 100669013);
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x0010DA18 File Offset: 0x0010BC18
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0010DA54 File Offset: 0x0010BC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128586, XrefRangeEnd = 128617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0010DAA4 File Offset: 0x0010BCA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128639, RefRangeEnd = 128640, XrefRangeStart = 128617, XrefRangeEnd = 128639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSpraySurface(WorldSpraySurfaceData surfaceData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surfaceData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiLoader.NativeMethodInfoPtr_LoadSpraySurface_Private_Void_WorldSpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0010DAE8 File Offset: 0x0010BCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128640, XrefRangeEnd = 128647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureStrokesHaveValidSize(SpraySurfaceData surfaceData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surfaceData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiLoader.NativeMethodInfoPtr_EnsureStrokesHaveValidSize_Private_Void_SpraySurfaceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00016D3F File Offset: 0x00014F3F
		public GraffitiLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpraySurface_Private_Void_WorldSpraySurfaceData_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_EnsureStrokesHaveValidSize_Private_Void_SpraySurfaceData_0;
	}
}
