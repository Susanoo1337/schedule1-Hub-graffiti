using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000562 RID: 1378
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x06007E35 RID: 32309 RVA: 0x0022D2F0 File Offset: 0x0022B4F0
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyItemDefinition()
		{
			Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr);
			PropertyItemDefinition.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, "Properties");
			PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679572);
			PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679573);
			PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr, 100679574);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0022D370 File Offset: 0x0022B570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241622, RefRangeEnd = 241623, XrefRangeStart = 241618, XrefRangeEnd = 241622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(List<Effect> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyItemDefinition.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Effect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0022D3C0 File Offset: 0x0022B5C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241627, RefRangeEnd = 241629, XrefRangeStart = 241623, XrefRangeEnd = 241627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProperty(Effect property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr_HasProperty_Public_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0022D410 File Offset: 0x0022B610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241637, RefRangeEnd = 241638, XrefRangeStart = 241629, XrefRangeEnd = 241637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0003BE82 File Offset: 0x0003A082
		public PropertyItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x06007E3A RID: 32314 RVA: 0x0022D44C File Offset: 0x0022B64C
		// (set) Token: 0x06007E3B RID: 32315 RVA: 0x0003BE8B File Offset: 0x0003A08B
		public unsafe List<Effect> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyItemDefinition.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005632 RID: 22066
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005633 RID: 22067
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_List_1_Effect_0;

		// Token: 0x04005634 RID: 22068
		private static readonly IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_Effect_0;

		// Token: 0x04005635 RID: 22069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
