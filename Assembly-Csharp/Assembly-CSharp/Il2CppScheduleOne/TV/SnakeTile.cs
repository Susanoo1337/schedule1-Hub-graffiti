using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000103 RID: 259
	public class SnakeTile : MonoBehaviour
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x000CDA30 File Offset: 0x000CBC30
		// Note: this type is marked as 'beforefieldinit'.
		static SnakeTile()
		{
			Il2CppClassPointerStore<SnakeTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "SnakeTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr);
			SnakeTile.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "<Type>k__BackingField");
			SnakeTile.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Position");
			SnakeTile.NativeFieldInfoPtr_SnakeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "SnakeColor");
			SnakeTile.NativeFieldInfoPtr_FoodColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "FoodColor");
			SnakeTile.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "RectTransform");
			SnakeTile.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, "Image");
			SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666648);
			SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666649);
			SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666650);
			SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666651);
			SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr, 100666652);
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x000CDB3C File Offset: 0x000CBD3C
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x000CDB78 File Offset: 0x000CBD78
		public unsafe SnakeTile.TileType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_get_Type_Public_get_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000CDBB8 File Offset: 0x000CBDB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 98640, RefRangeEnd = 98645, XrefRangeStart = 98638, XrefRangeEnd = 98640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetType(SnakeTile.TileType type, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000CDC04 File Offset: 0x000CBE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98657, RefRangeEnd = 98658, XrefRangeStart = 98645, XrefRangeEnd = 98657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector2 position, float tileSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000CDC50 File Offset: 0x000CBE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98658, XrefRangeEnd = 98661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		public SnakeTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000CDC8C File Offset: 0x000CBE8C
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x0000DC75 File Offset: 0x0000BE75
		public unsafe SnakeTile.TileType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x000CDCB4 File Offset: 0x000CBEB4
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x000CDCDC File Offset: 0x000CBEDC
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000DCAB File Offset: 0x0000BEAB
		public unsafe Color SnakeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_SnakeColor)) = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x000CDD04 File Offset: 0x000CBF04
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000DCC6 File Offset: 0x0000BEC6
		public unsafe Color FoodColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_FoodColor)) = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x000CDD2C File Offset: 0x000CBF2C
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000DCE1 File Offset: 0x0000BEE1
		public unsafe RectTransform RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x000CDD5C File Offset: 0x000CBF5C
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000DD00 File Offset: 0x0000BF00
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SnakeTile.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_SnakeColor;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr_FoodColor;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_TileType_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_TileType_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_SetType_Public_Void_TileType_Int32_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector2_Single_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200093E RID: 2366
		[OriginalName("Assembly-CSharp.dll", "", "TileType")]
		public enum TileType
		{
			// Token: 0x04009364 RID: 37732
			Empty,
			// Token: 0x04009365 RID: 37733
			Snake,
			// Token: 0x04009366 RID: 37734
			Food
		}
	}
}
