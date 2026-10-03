using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001AC RID: 428
	public class IGenericSaveable : Il2CppObjectBase
	{
		// Token: 0x06002AB7 RID: 10935 RVA: 0x001082B8 File Offset: 0x001064B8
		// Note: this type is marked as 'beforefieldinit'.
		static IGenericSaveable()
		{
			Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "IGenericSaveable");
			IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668754);
			IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668755);
			IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668756);
			IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGenericSaveable>.NativeClassPtr, 100668757);
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x00108330 File Offset: 0x00106530
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00108378 File Offset: 0x00106578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124544, XrefRangeEnd = 124559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x001083B4 File Offset: 0x001065B4
		[CallerCount(0)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00108404 File Offset: 0x00106604
		[CallerCount(0)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGenericSaveable.NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00016409 File Offset: 0x00014609
		public IGenericSaveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Void_GenericSaveData_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Abstract_Virtual_New_GenericSaveData_0;
	}
}
