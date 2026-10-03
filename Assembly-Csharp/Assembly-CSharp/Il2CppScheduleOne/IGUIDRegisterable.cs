using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000BB RID: 187
	public class IGUIDRegisterable : Il2CppObjectBase
	{
		// Token: 0x0600110D RID: 4365 RVA: 0x000B4204 File Offset: 0x000B2404
		// Note: this type is marked as 'beforefieldinit'.
		static IGUIDRegisterable()
		{
			Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "IGUIDRegisterable");
			IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100665780);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100665781);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100665782);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000B4268 File Offset: 0x000B2468
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x000B42B0 File Offset: 0x000B24B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88764, XrefRangeEnd = 88776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000B4300 File Offset: 0x000B2500
		[CallerCount(0)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00009E41 File Offset: 0x00008041
		public IGUIDRegisterable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0;
	}
}
