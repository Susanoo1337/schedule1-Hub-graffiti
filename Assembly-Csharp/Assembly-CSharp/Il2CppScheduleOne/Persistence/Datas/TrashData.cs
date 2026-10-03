using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class TrashData : SaveData
	{
		// Token: 0x06003172 RID: 12658 RVA: 0x0011E804 File Offset: 0x0011CA04
		// Note: this type is marked as 'beforefieldinit'.
		static TrashData()
		{
			Il2CppClassPointerStore<TrashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashData>.NativeClassPtr);
			TrashData.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Items");
			TrashData.NativeFieldInfoPtr_Generators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashData>.NativeClassPtr, "Generators");
			TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashData>.NativeClassPtr, 100669476);
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x0011E870 File Offset: 0x0011CA70
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashData(Il2CppReferenceArray<TrashItemData> trash, Il2CppReferenceArray<TrashGeneratorData> generators) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generators);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00019895 File Offset: 0x00017A95
		public TrashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x0011E8D0 File Offset: 0x0011CAD0
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x0001989E File Offset: 0x00017A9E
		public unsafe Il2CppReferenceArray<TrashItemData> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x0011E900 File Offset: 0x0011CB00
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x000198BD File Offset: 0x00017ABD
		public unsafe Il2CppReferenceArray<TrashGeneratorData> Generators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Generators);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashGeneratorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashData.NativeFieldInfoPtr_Generators), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020FF RID: 8447
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04002100 RID: 8448
		private static readonly IntPtr NativeFieldInfoPtr_Generators;

		// Token: 0x04002101 RID: 8449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrashItemData_Il2CppReferenceArray_1_TrashGeneratorData_0;
	}
}
