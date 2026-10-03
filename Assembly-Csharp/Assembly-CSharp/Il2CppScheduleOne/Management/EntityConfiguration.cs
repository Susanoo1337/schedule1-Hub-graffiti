using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D9 RID: 729
	public class EntityConfiguration : Object
	{
		// Token: 0x060039AA RID: 14762 RVA: 0x0013C6C0 File Offset: 0x0013A8C0
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConfiguration()
		{
			Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "EntityConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr);
			EntityConfiguration.NativeFieldInfoPtr_NameCharacterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "NameCharacterLimit");
			EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Replicator>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Configurable>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "Fields");
			EntityConfiguration.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "onChanged");
			EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<IsSelected>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Name>k__BackingField");
			EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670660);
			EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670661);
			EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670662);
			EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670663);
			EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670664);
			EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670665);
			EntityConfiguration.NativeMethodInfoPtr_get_Name_Public_get_StringField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670666);
			EntityConfiguration.NativeMethodInfoPtr_set_Name_Private_set_Void_StringField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670667);
			EntityConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670668);
			EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670669);
			EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670670);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670671);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670672);
			EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670673);
			EntityConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670674);
			EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670675);
			EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670676);
			EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670677);
			EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670678);
			EntityConfiguration.NativeMethodInfoPtr_GetField_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670679);
			EntityConfiguration.NativeMethodInfoPtr___ctor_b__20_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100670680);
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x0013C920 File Offset: 0x0013AB20
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x0013C960 File Offset: 0x0013AB60
		public unsafe ConfigurationReplicator Replicator
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x0013C9A4 File Offset: 0x0013ABA4
		// (set) Token: 0x060039AE RID: 14766 RVA: 0x0013C9E4 File Offset: 0x0013ABE4
		public unsafe IConfigurable Configurable
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x0013CA28 File Offset: 0x0013AC28
		// (set) Token: 0x060039B0 RID: 14768 RVA: 0x0013CA64 File Offset: 0x0013AC64
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x0013CAA4 File Offset: 0x0013ACA4
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x0013CAE4 File Offset: 0x0013ACE4
		public unsafe StringField Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Name_Public_get_StringField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringField>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Name_Private_set_Void_StringField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x0013CB28 File Offset: 0x0013AD28
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllowRename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x0013CB70 File Offset: 0x0013AD70
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 147748, RefRangeEnd = 147763, XrefRangeStart = 147716, XrefRangeEnd = 147748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, string defaultName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x0013CBE0 File Offset: 0x0013ADE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0013CC14 File Offset: 0x0013AE14
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 147765, RefRangeEnd = 147780, XrefRangeStart = 147763, XrefRangeEnd = 147765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0013CC68 File Offset: 0x0013AE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147780, XrefRangeEnd = 147802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicateDefaults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0013CCB8 File Offset: 0x0013AEB8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 142897, RefRangeEnd = 142934, XrefRangeStart = 142897, XrefRangeEnd = 142934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0013CD30 File Offset: 0x0013AF30
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 147802, RefRangeEnd = 147809, XrefRangeStart = 147802, XrefRangeEnd = 147802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0013CD6C File Offset: 0x0013AF6C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 147809, RefRangeEnd = 147823, XrefRangeStart = 147809, XrefRangeEnd = 147809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0013CDA8 File Offset: 0x0013AFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147823, RefRangeEnd = 147824, XrefRangeStart = 147823, XrefRangeEnd = 147823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x0013CDF0 File Offset: 0x0013AFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147824, XrefRangeEnd = 147830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x0013CE34 File Offset: 0x0013B034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147845, RefRangeEnd = 147846, XrefRangeStart = 147830, XrefRangeEnd = 147845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetField<T>() where T : ConfigField
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.MethodInfoStoreGeneric_GetField_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0013CE70 File Offset: 0x0013B070
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__20_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr___ctor_b__20_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x0001D016 File Offset: 0x0001B216
		public EntityConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x0013CEB4 File Offset: 0x0013B0B4
		// (set) Token: 0x060039C2 RID: 14786 RVA: 0x0001D01F File Offset: 0x0001B21F
		public unsafe static int NameCharacterLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EntityConfiguration.NativeFieldInfoPtr_NameCharacterLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityConfiguration.NativeFieldInfoPtr_NameCharacterLimit, (void*)(&value));
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060039C3 RID: 14787 RVA: 0x0013CED0 File Offset: 0x0013B0D0
		// (set) Token: 0x060039C4 RID: 14788 RVA: 0x0001D02D File Offset: 0x0001B22D
		public unsafe ConfigurationReplicator _Replicator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x0013CF00 File Offset: 0x0013B100
		// (set) Token: 0x060039C6 RID: 14790 RVA: 0x0001D04C File Offset: 0x0001B24C
		public unsafe IConfigurable _Configurable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x060039C7 RID: 14791 RVA: 0x0013CF30 File Offset: 0x0013B130
		// (set) Token: 0x060039C8 RID: 14792 RVA: 0x0001D06B File Offset: 0x0001B26B
		public unsafe List<ConfigField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConfigField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x0013CF60 File Offset: 0x0013B160
		// (set) Token: 0x060039CA RID: 14794 RVA: 0x0001D08A File Offset: 0x0001B28A
		public unsafe UnityEvent onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x0013CF90 File Offset: 0x0013B190
		// (set) Token: 0x060039CC RID: 14796 RVA: 0x0001D0A9 File Offset: 0x0001B2A9
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x0013CFB8 File Offset: 0x0013B1B8
		// (set) Token: 0x060039CE RID: 14798 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		public unsafe StringField _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Name_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeFieldInfoPtr_NameCharacterLimit;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeFieldInfoPtr__Replicator_k__BackingField;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr__Configurable_k__BackingField;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_StringField_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Private_set_Void_StringField_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_AllowRename_Public_Virtual_New_Boolean_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_String_0;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanged_Protected_Void_0;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_T_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__20_0_Private_Void_String_0;

		// Token: 0x02000A30 RID: 2608
		private sealed class MethodInfoStoreGeneric_GetField_Public_T_0<T>
		{
			// Token: 0x040097F3 RID: 38899
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EntityConfiguration.NativeMethodInfoPtr_GetField_Public_T_0, Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
