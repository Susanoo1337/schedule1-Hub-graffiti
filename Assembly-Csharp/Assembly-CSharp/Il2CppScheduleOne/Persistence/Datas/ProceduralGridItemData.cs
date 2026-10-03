using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000254 RID: 596
	[Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x0011B170 File Offset: 0x00119370
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItemData()
		{
			Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProceduralGridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr);
			ProceduralGridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "Rotation");
			ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "FootprintMatches");
			ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, 100669435);
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0011B1DC File Offset: 0x001193DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135191, RefRangeEnd = 135192, XrefRangeStart = 135186, XrefRangeEnd = 135191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItemData(Guid guid, ItemInstance item, int loadOrder, int rotation, Il2CppReferenceArray<FootprintMatchData> footprintMatches) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(footprintMatches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00018BC0 File Offset: 0x00016DC0
		public ProceduralGridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x0011B264 File Offset: 0x00119464
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x00018BC9 File Offset: 0x00016DC9
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x0011B28C File Offset: 0x0011948C
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x00018BE4 File Offset: 0x00016DE4
		public unsafe Il2CppReferenceArray<FootprintMatchData> FootprintMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FootprintMatchData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002072 RID: 8306
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002073 RID: 8307
		private static readonly IntPtr NativeFieldInfoPtr_FootprintMatches;

		// Token: 0x04002074 RID: 8308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0;
	}
}
