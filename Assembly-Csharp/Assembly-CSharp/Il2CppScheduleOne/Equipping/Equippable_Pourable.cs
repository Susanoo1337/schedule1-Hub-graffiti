using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057F RID: 1407
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x06008036 RID: 32822 RVA: 0x0023375C File Offset: 0x0023195C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Pourable()
		{
			Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr);
			Equippable_Pourable.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "InteractionRange");
			Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "PourablePrefab");
			Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679792);
			Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679793);
			Equippable_Pourable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679794);
			Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679795);
			Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679796);
			Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679797);
			Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679798);
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x00233854 File Offset: 0x00231A54
		// (set) Token: 0x06008038 RID: 32824 RVA: 0x0023388C File Offset: 0x00231A8C
		public unsafe string InteractionLabel
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x002338D0 File Offset: 0x00231AD0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x0023390C File Offset: 0x00231B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243813, XrefRangeEnd = 243845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x00233948 File Offset: 0x00231B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243845, XrefRangeEnd = 243849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartPourTask(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803C RID: 32828 RVA: 0x00233998 File Offset: 0x00231B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243849, XrefRangeEnd = 243852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour(GrowContainer growContainer, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600803D RID: 32829 RVA: 0x00233A0C File Offset: 0x00231C0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243859, RefRangeEnd = 243862, XrefRangeStart = 243852, XrefRangeEnd = 243859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600803E RID: 32830 RVA: 0x0003CF4B File Offset: 0x0003B14B
		public Equippable_Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600803F RID: 32831 RVA: 0x00233A48 File Offset: 0x00231C48
		// (set) Token: 0x06008040 RID: 32832 RVA: 0x0003CF54 File Offset: 0x0003B154
		public unsafe static float InteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange, (void*)(&value));
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06008041 RID: 32833 RVA: 0x00233A64 File Offset: 0x00231C64
		// (set) Token: 0x06008042 RID: 32834 RVA: 0x0003CF62 File Offset: 0x0003B162
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x06008043 RID: 32835 RVA: 0x00233A8C File Offset: 0x00231C8C
		// (set) Token: 0x06008044 RID: 32836 RVA: 0x0003CF81 File Offset: 0x0003B181
		public unsafe Pourable PourablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005772 RID: 22386
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x04005773 RID: 22387
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x04005774 RID: 22388
		private static readonly IntPtr NativeFieldInfoPtr_PourablePrefab;

		// Token: 0x04005775 RID: 22389
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_get_String_0;

		// Token: 0x04005776 RID: 22390
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_set_Void_String_0;

		// Token: 0x04005777 RID: 22391
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005778 RID: 22392
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005779 RID: 22393
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_GrowContainer_0;

		// Token: 0x0400577A RID: 22394
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_GrowContainer_byref_String_0;

		// Token: 0x0400577B RID: 22395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
