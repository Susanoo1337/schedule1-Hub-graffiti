using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000532 RID: 1330
	public class StoredItem_GenericBox : StoredItem
	{
		// Token: 0x060078DE RID: 30942 RVA: 0x00218FE4 File Offset: 0x002171E4
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_GenericBox()
		{
			Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem_GenericBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr);
			StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "ReferenceIconWidth");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon1");
			StoredItem_GenericBox.NativeFieldInfoPtr_icon2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "icon2");
			StoredItem_GenericBox.NativeFieldInfoPtr_IconScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, "IconScale");
			StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678847);
			StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr, 100678848);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x0021908C File Offset: 0x0021728C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233386, XrefRangeEnd = 233401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_GenericBox.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00219108 File Offset: 0x00217308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233401, XrefRangeEnd = 233402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_GenericBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_GenericBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_GenericBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x0003987E File Offset: 0x00037A7E
		public StoredItem_GenericBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x00219144 File Offset: 0x00217344
		// (set) Token: 0x060078E3 RID: 30947 RVA: 0x00039887 File Offset: 0x00037A87
		public unsafe static float ReferenceIconWidth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoredItem_GenericBox.NativeFieldInfoPtr_ReferenceIconWidth, (void*)(&value));
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x00219160 File Offset: 0x00217360
		// (set) Token: 0x060078E5 RID: 30949 RVA: 0x00039895 File Offset: 0x00037A95
		public unsafe SpriteRenderer icon1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x00219190 File Offset: 0x00217390
		// (set) Token: 0x060078E7 RID: 30951 RVA: 0x000398B4 File Offset: 0x00037AB4
		public unsafe SpriteRenderer icon2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_icon2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x060078E8 RID: 30952 RVA: 0x002191C0 File Offset: 0x002173C0
		// (set) Token: 0x060078E9 RID: 30953 RVA: 0x000398D3 File Offset: 0x00037AD3
		public unsafe float IconScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_GenericBox.NativeFieldInfoPtr_IconScale)) = value;
			}
		}

		// Token: 0x04005263 RID: 21091
		private static readonly IntPtr NativeFieldInfoPtr_ReferenceIconWidth;

		// Token: 0x04005264 RID: 21092
		private static readonly IntPtr NativeFieldInfoPtr_icon1;

		// Token: 0x04005265 RID: 21093
		private static readonly IntPtr NativeFieldInfoPtr_icon2;

		// Token: 0x04005266 RID: 21094
		private static readonly IntPtr NativeFieldInfoPtr_IconScale;

		// Token: 0x04005267 RID: 21095
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04005268 RID: 21096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
