using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000247 RID: 583
	public class CauldronData : GridItemData
	{
		// Token: 0x06002FC3 RID: 12227 RVA: 0x00119870 File Offset: 0x00117A70
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronData()
		{
			Il2CppClassPointerStore<CauldronData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronData>.NativeClassPtr);
			CauldronData.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Ingredients");
			CauldronData.NativeFieldInfoPtr_Liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Liquid");
			CauldronData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Output");
			CauldronData.NativeFieldInfoPtr_RemainingCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "RemainingCookTime");
			CauldronData.NativeFieldInfoPtr_InputQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "InputQuality");
			CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, 100669421);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00119918 File Offset: 0x00117B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135081, RefRangeEnd = 135082, XrefRangeStart = 135072, XrefRangeEnd = 135081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(liquid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingCookTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00018690 File Offset: 0x00016890
		public CauldronData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x00119A08 File Offset: 0x00117C08
		// (set) Token: 0x06002FC7 RID: 12231 RVA: 0x00018699 File Offset: 0x00016899
		public unsafe ItemSet Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x00119A38 File Offset: 0x00117C38
		// (set) Token: 0x06002FC9 RID: 12233 RVA: 0x000186B8 File Offset: 0x000168B8
		public unsafe ItemSet Liquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x00119A68 File Offset: 0x00117C68
		// (set) Token: 0x06002FCB RID: 12235 RVA: 0x000186D7 File Offset: 0x000168D7
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x00119A98 File Offset: 0x00117C98
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x000186F6 File Offset: 0x000168F6
		public unsafe int RemainingCookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime)) = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x00119AC0 File Offset: 0x00117CC0
		// (set) Token: 0x06002FCF RID: 12239 RVA: 0x00018711 File Offset: 0x00016911
		public unsafe EQuality InputQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality)) = value;
			}
		}

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_Liquid;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeFieldInfoPtr_RemainingCookTime;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr_InputQuality;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0;
	}
}
