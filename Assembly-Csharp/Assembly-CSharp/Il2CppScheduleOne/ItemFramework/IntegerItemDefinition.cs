using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200034D RID: 845
	[Serializable]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		// Token: 0x060047EC RID: 18412 RVA: 0x0016F9C8 File Offset: 0x0016DBC8
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemDefinition()
		{
			Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IntegerItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr);
			IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, "DefaultValue");
			IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100672507);
			IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr, 100672508);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0016FA34 File Offset: 0x0016DC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167247, XrefRangeEnd = 167251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0016FA8C File Offset: 0x0016DC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166837, XrefRangeEnd = 166838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x000230DC File Offset: 0x000212DC
		public IntegerItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x0016FAC8 File Offset: 0x0016DCC8
		// (set) Token: 0x060047F1 RID: 18417 RVA: 0x000230E5 File Offset: 0x000212E5
		public unsafe int DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemDefinition.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
