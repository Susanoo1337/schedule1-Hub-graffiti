using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200035B RID: 859
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x060048E7 RID: 18663 RVA: 0x0017316C File Offset: 0x0017136C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemDefinition()
		{
			Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr);
			QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, "DefaultQuality");
			QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100672642);
			QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100672643);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x001731D8 File Offset: 0x001713D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168716, XrefRangeEnd = 168720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00173230 File Offset: 0x00171430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168721, RefRangeEnd = 168722, XrefRangeStart = 168720, XrefRangeEnd = 168721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x00023703 File Offset: 0x00021903
		public QualityItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0017326C File Offset: 0x0017146C
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x0002370C File Offset: 0x0002190C
		public unsafe EQuality DefaultQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality)) = value;
			}
		}

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuality;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
