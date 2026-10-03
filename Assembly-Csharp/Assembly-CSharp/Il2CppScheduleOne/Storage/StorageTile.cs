using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200052C RID: 1324
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x06007878 RID: 30840 RVA: 0x00217BD8 File Offset: 0x00215DD8
		// Note: this type is marked as 'beforefieldinit'.
		static StorageTile()
		{
			Il2CppClassPointerStore<StorageTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageTile>.NativeClassPtr);
			StorageTile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "x");
			StorageTile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "y");
			StorageTile.NativeFieldInfoPtr_ownerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "ownerGrid");
			StorageTile.NativeFieldInfoPtr_onOccupantChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "onOccupantChanged");
			StorageTile.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "<occupant>k__BackingField");
			StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678806);
			StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678807);
			StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678808);
			StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678809);
			StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678810);
			StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678811);
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x06007879 RID: 30841 RVA: 0x00217CE4 File Offset: 0x00215EE4
		public unsafe StorageGrid _ownerGrid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x00217D24 File Offset: 0x00215F24
		// (set) Token: 0x0600787B RID: 30843 RVA: 0x00217D64 File Offset: 0x00215F64
		public unsafe StoredItem occupant
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00217DA8 File Offset: 0x00215FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232778, XrefRangeEnd = 232779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00217E18 File Offset: 0x00216018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232793, RefRangeEnd = 232795, XrefRangeStart = 232779, XrefRangeEnd = 232793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(StoredItem occ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x00217E5C File Offset: 0x0021605C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x00039503 File Offset: 0x00037703
		public StorageTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x06007880 RID: 30848 RVA: 0x00217E98 File Offset: 0x00216098
		// (set) Token: 0x06007881 RID: 30849 RVA: 0x0003950C File Offset: 0x0003770C
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x00217EC0 File Offset: 0x002160C0
		// (set) Token: 0x06007883 RID: 30851 RVA: 0x00039527 File Offset: 0x00037727
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00217EE8 File Offset: 0x002160E8
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x00039542 File Offset: 0x00037742
		public unsafe StorageGrid ownerGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x00217F18 File Offset: 0x00216118
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x00039561 File Offset: 0x00037761
		public unsafe Action onOccupantChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x00217F48 File Offset: 0x00216148
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x00039580 File Offset: 0x00037780
		public unsafe StoredItem _occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005224 RID: 21028
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04005225 RID: 21029
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04005226 RID: 21030
		private static readonly IntPtr NativeFieldInfoPtr_ownerGrid;

		// Token: 0x04005227 RID: 21031
		private static readonly IntPtr NativeFieldInfoPtr_onOccupantChanged;

		// Token: 0x04005228 RID: 21032
		private static readonly IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x04005229 RID: 21033
		private static readonly IntPtr NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0;

		// Token: 0x0400522A RID: 21034
		private static readonly IntPtr NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0;

		// Token: 0x0400522B RID: 21035
		private static readonly IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0;

		// Token: 0x0400522C RID: 21036
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0;

		// Token: 0x0400522D RID: 21037
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0;

		// Token: 0x0400522E RID: 21038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
