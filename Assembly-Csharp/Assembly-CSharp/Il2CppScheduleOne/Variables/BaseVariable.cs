using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F3 RID: 243
	public class BaseVariable : Object
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x000C84A0 File Offset: 0x000C66A0
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVariable()
		{
			Il2CppClassPointerStore<BaseVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "BaseVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr);
			BaseVariable.NativeFieldInfoPtr_ReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "ReplicationMode");
			BaseVariable.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Name");
			BaseVariable.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Persistent");
			BaseVariable.NativeFieldInfoPtr_VariableMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "VariableMode");
			BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "<Owner>k__BackingField");
			BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666507);
			BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666508);
			BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666509);
			BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666510);
			BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666511);
			BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666512);
			BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666513);
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000C85C0 File Offset: 0x000C67C0
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x000C8600 File Offset: 0x000C6800
		public unsafe Player Owner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000C8644 File Offset: 0x000C6844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97189, RefRangeEnd = 97191, XrefRangeStart = 97146, XrefRangeEnd = 97189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000C86CC File Offset: 0x000C68CC
		[CallerCount(0)]
		public unsafe virtual Object GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000C8718 File Offset: 0x000C6918
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object value, bool replicate = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x000C8774 File Offset: 0x000C6974
		[CallerCount(0)]
		public unsafe virtual void ReplicateValue(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x000C87C4 File Offset: 0x000C69C4
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public BaseVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x000C882C File Offset: 0x000C6A2C
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x0000CD95 File Offset: 0x0000AF95
		public unsafe EVariableReplicationMode ReplicationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode)) = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x000C8854 File Offset: 0x000C6A54
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x000C887C File Offset: 0x000C6A7C
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0000CDCF File Offset: 0x0000AFCF
		public unsafe bool Persistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000C88A4 File Offset: 0x000C6AA4
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0000CDEA File Offset: 0x0000AFEA
		public unsafe EVariableMode VariableMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode)) = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x000C88CC File Offset: 0x000C6ACC
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x0000CE05 File Offset: 0x0000B005
		public unsafe Player _Owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_ReplicationMode;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeFieldInfoPtr_VariableMode;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Player_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0;
	}
}
