using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001E1 RID: 481
	public class LegacyEmployeeLoader : LegacyNPCLoader
	{
		// Token: 0x06002CC5 RID: 11461 RVA: 0x0010FE40 File Offset: 0x0010E040
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyEmployeeLoader()
		{
			Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyEmployeeLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr);
			LegacyEmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100669135);
			LegacyEmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100669136);
			LegacyEmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100669137);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x0010FEAC File Offset: 0x0010E0AC
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130838, XrefRangeEnd = 130845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyEmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0010FEF0 File Offset: 0x0010E0F0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 130514, RefRangeEnd = 130524, XrefRangeStart = 130514, XrefRangeEnd = 130524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyEmployeeLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyEmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x0010FF2C File Offset: 0x0010E12C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130912, RefRangeEnd = 130916, XrefRangeStart = 130845, XrefRangeEnd = 130912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee LoadAndCreateEmployee(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyEmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00016E5F File Offset: 0x0001505F
		public LegacyEmployeeLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0;
	}
}
