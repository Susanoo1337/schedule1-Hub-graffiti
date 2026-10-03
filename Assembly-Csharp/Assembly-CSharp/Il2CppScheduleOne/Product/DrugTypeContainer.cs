using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200054C RID: 1356
	[Serializable]
	public class DrugTypeContainer : Object
	{
		// Token: 0x06007BDE RID: 31710 RVA: 0x002234C8 File Offset: 0x002216C8
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeContainer()
		{
			Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr);
			DrugTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, "DrugType");
			DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr, 100679208);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x00223520 File Offset: 0x00221720
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrugTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrugTypeContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x0003AFFE File Offset: 0x000391FE
		public DrugTypeContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0022355C File Offset: 0x0022175C
		// (set) Token: 0x06007BE2 RID: 31714 RVA: 0x0003B007 File Offset: 0x00039207
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrugTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x04005466 RID: 21606
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04005467 RID: 21607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
