using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E3 RID: 739
	public class ConfigField : Object
	{
		// Token: 0x06003AA0 RID: 15008 RVA: 0x00140414 File Offset: 0x0013E614
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigField()
		{
			Il2CppClassPointerStore<ConfigField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigField>.NativeClassPtr);
			ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, "<ParentConfig>k__BackingField");
			ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100670800);
			ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100670801);
			ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100670802);
			ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigField>.NativeClassPtr, 100670803);
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x001404A8 File Offset: 0x0013E6A8
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x001404E8 File Offset: 0x0013E6E8
		public unsafe EntityConfiguration ParentConfig
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x0014052C File Offset: 0x0013E72C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 149062, RefRangeEnd = 149073, XrefRangeStart = 149054, XrefRangeEnd = 149062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x00140578 File Offset: 0x0013E778
		[CallerCount(0)]
		public unsafe virtual bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigField.NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x0001D63C File Offset: 0x0001B83C
		public ConfigField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x001405C0 File Offset: 0x0013E7C0
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x0001D645 File Offset: 0x0001B845
		public unsafe EntityConfiguration _ParentConfig_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigField.NativeFieldInfoPtr__ParentConfig_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeFieldInfoPtr__ParentConfig_k__BackingField;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentConfig_Public_get_EntityConfiguration_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentConfig_Protected_set_Void_EntityConfiguration_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Abstract_Virtual_New_Boolean_0;
	}
}
