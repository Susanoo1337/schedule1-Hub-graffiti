using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F4 RID: 244
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x000C88FC File Offset: 0x000C6AFC
		// Note: this type is marked as 'beforefieldinit'.
		static BoolVariable()
		{
			Il2CppClassPointerStore<BoolVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "BoolVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr);
			BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666514);
			BoolVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666515);
			BoolVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666516);
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x000C8968 File Offset: 0x000C6B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97191, XrefRangeEnd = 97194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000C8A00 File Offset: 0x000C6C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97194, XrefRangeEnd = 97202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDeserialize(string valueString, out bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(valueString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000C8A68 File Offset: 0x000C6C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97202, XrefRangeEnd = 97214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0000CE24 File Offset: 0x0000B024
		public BoolVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0;
	}
}
