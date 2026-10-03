using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001BD RID: 445
	public class DeliveriesLoader : Loader
	{
		// Token: 0x06002C1D RID: 11293 RVA: 0x0010D460 File Offset: 0x0010B660
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesLoader()
		{
			Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "DeliveriesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr);
			DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668998);
			DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100668999);
			DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr, 100669000);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x0010D4CC File Offset: 0x0010B6CC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x0010D508 File Offset: 0x0010B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128425, XrefRangeEnd = 128473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveriesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x0010D558 File Offset: 0x0010B758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128510, RefRangeEnd = 128511, XrefRangeStart = 128473, XrefRangeEnd = 128510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVehicle(string vehiclePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehiclePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesLoader.NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00016D1B File Offset: 0x00014F1B
		public DeliveriesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr_LoadVehicle_Public_Void_String_0;
	}
}
