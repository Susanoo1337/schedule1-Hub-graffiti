using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E5 RID: 741
	public class NPCField : ConfigField
	{
		// Token: 0x06003AB9 RID: 15033 RVA: 0x001409A0 File Offset: 0x0013EBA0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCField()
		{
			Il2CppClassPointerStore<NPCField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NPCField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCField>.NativeClassPtr);
			NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "<SelectedNPC>k__BackingField");
			NPCField.NativeFieldInfoPtr_TypeRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "TypeRequirement");
			NPCField.NativeFieldInfoPtr_onNPCChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCField>.NativeClassPtr, "onNPCChanged");
			NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670811);
			NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670812);
			NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670813);
			NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670814);
			NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670815);
			NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670816);
			NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670817);
			NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCField>.NativeClassPtr, 100670818);
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00140AAC File Offset: 0x0013ECAC
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x00140AEC File Offset: 0x0013ECEC
		public unsafe NPC SelectedNPC
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x00140B30 File Offset: 0x0013ED30
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 149157, RefRangeEnd = 149166, XrefRangeStart = 149149, XrefRangeEnd = 149157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABD RID: 15037 RVA: 0x00140B7C File Offset: 0x0013ED7C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 149175, RefRangeEnd = 149195, XrefRangeStart = 149166, XrefRangeEnd = 149175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ABE RID: 15038 RVA: 0x00140BCC File Offset: 0x0013EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149195, XrefRangeEnd = 149199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesNPCMatchRequirement(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x00140C1C File Offset: 0x0013EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149199, XrefRangeEnd = 149203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x00140C64 File Offset: 0x0013EE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149203, XrefRangeEnd = 149215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_GetData_Public_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCFieldData>(intPtr3) : null;
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x00140CA4 File Offset: 0x0013EEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149215, XrefRangeEnd = 149236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCField.NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x0001D6E5 File Offset: 0x0001B8E5
		public NPCField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x00140CE8 File Offset: 0x0013EEE8
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x0001D6EE File Offset: 0x0001B8EE
		public unsafe NPC _SelectedNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr__SelectedNPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x00140D18 File Offset: 0x0013EF18
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x0001D70D File Offset: 0x0001B90D
		public unsafe Type TypeRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_TypeRequirement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00140D48 File Offset: 0x0013EF48
		// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x0001D72C File Offset: 0x0001B92C
		public unsafe UnityEvent<NPC> onNPCChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCField.NativeFieldInfoPtr_onNPCChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002797 RID: 10135
		private static readonly IntPtr NativeFieldInfoPtr__SelectedNPC_k__BackingField;

		// Token: 0x04002798 RID: 10136
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirement;

		// Token: 0x04002799 RID: 10137
		private static readonly IntPtr NativeFieldInfoPtr_onNPCChanged;

		// Token: 0x0400279A RID: 10138
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedNPC_Public_get_NPC_0;

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedNPC_Protected_set_Void_NPC_0;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_Boolean_0;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeMethodInfoPtr_DoesNPCMatchRequirement_Public_Boolean_NPC_0;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NPCFieldData_0;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCFieldData_0;
	}
}
