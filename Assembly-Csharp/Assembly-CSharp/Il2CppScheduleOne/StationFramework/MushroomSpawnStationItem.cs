using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000540 RID: 1344
	public class MushroomSpawnStationItem : StationItem
	{
		// Token: 0x06007ACB RID: 31435 RVA: 0x002200D8 File Offset: 0x0021E2D8
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomSpawnStationItem()
		{
			Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "MushroomSpawnStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr);
			MushroomSpawnStationItem.NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, "_renderers");
			MushroomSpawnStationItem.NativeFieldInfoPtr__materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, "_materialIndex");
			MushroomSpawnStationItem.NativeFieldInfoPtr__InjectionPortCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, "<InjectionPortCollider>k__BackingField");
			MushroomSpawnStationItem.NativeFieldInfoPtr__injectionPortHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, "_injectionPortHighlight");
			MushroomSpawnStationItem.NativeMethodInfoPtr_get_InjectionPortCollider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679101);
			MushroomSpawnStationItem.NativeMethodInfoPtr_set_InjectionPortCollider_Private_set_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679102);
			MushroomSpawnStationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679103);
			MushroomSpawnStationItem.NativeMethodInfoPtr_SetInocculationAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679104);
			MushroomSpawnStationItem.NativeMethodInfoPtr_SetInjectionPortHighlightActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679105);
			MushroomSpawnStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr, 100679106);
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x002201D0 File Offset: 0x0021E3D0
		// (set) Token: 0x06007ACD RID: 31437 RVA: 0x00220210 File Offset: 0x0021E410
		public unsafe Collider InjectionPortCollider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationItem.NativeMethodInfoPtr_get_InjectionPortCollider_Public_get_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationItem.NativeMethodInfoPtr_set_InjectionPortCollider_Private_set_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x00220254 File Offset: 0x0021E454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235186, XrefRangeEnd = 235203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomSpawnStationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x00220290 File Offset: 0x0021E490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235210, RefRangeEnd = 235211, XrefRangeStart = 235203, XrefRangeEnd = 235210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInocculationAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationItem.NativeMethodInfoPtr_SetInocculationAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x002202D0 File Offset: 0x0021E4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 235213, RefRangeEnd = 235215, XrefRangeStart = 235211, XrefRangeEnd = 235213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInjectionPortHighlightActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationItem.NativeMethodInfoPtr_SetInjectionPortHighlightActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x00220310 File Offset: 0x0021E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomSpawnStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomSpawnStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomSpawnStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0003A678 File Offset: 0x00038878
		public MushroomSpawnStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x06007AD3 RID: 31443 RVA: 0x0022034C File Offset: 0x0021E54C
		// (set) Token: 0x06007AD4 RID: 31444 RVA: 0x0003A681 File Offset: 0x00038881
		public unsafe Il2CppReferenceArray<MeshRenderer> _renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06007AD5 RID: 31445 RVA: 0x0022037C File Offset: 0x0021E57C
		// (set) Token: 0x06007AD6 RID: 31446 RVA: 0x0003A6A0 File Offset: 0x000388A0
		public unsafe int _materialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__materialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__materialIndex)) = value;
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06007AD7 RID: 31447 RVA: 0x002203A4 File Offset: 0x0021E5A4
		// (set) Token: 0x06007AD8 RID: 31448 RVA: 0x0003A6BB File Offset: 0x000388BB
		public unsafe Collider _InjectionPortCollider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__InjectionPortCollider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__InjectionPortCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06007AD9 RID: 31449 RVA: 0x002203D4 File Offset: 0x0021E5D4
		// (set) Token: 0x06007ADA RID: 31450 RVA: 0x0003A6DA File Offset: 0x000388DA
		public unsafe GameObject _injectionPortHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__injectionPortHighlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomSpawnStationItem.NativeFieldInfoPtr__injectionPortHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053BD RID: 21437
		private static readonly IntPtr NativeFieldInfoPtr__renderers;

		// Token: 0x040053BE RID: 21438
		private static readonly IntPtr NativeFieldInfoPtr__materialIndex;

		// Token: 0x040053BF RID: 21439
		private static readonly IntPtr NativeFieldInfoPtr__InjectionPortCollider_k__BackingField;

		// Token: 0x040053C0 RID: 21440
		private static readonly IntPtr NativeFieldInfoPtr__injectionPortHighlight;

		// Token: 0x040053C1 RID: 21441
		private static readonly IntPtr NativeMethodInfoPtr_get_InjectionPortCollider_Public_get_Collider_0;

		// Token: 0x040053C2 RID: 21442
		private static readonly IntPtr NativeMethodInfoPtr_set_InjectionPortCollider_Private_set_Void_Collider_0;

		// Token: 0x040053C3 RID: 21443
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040053C4 RID: 21444
		private static readonly IntPtr NativeMethodInfoPtr_SetInocculationAmount_Public_Void_Single_0;

		// Token: 0x040053C5 RID: 21445
		private static readonly IntPtr NativeMethodInfoPtr_SetInjectionPortHighlightActive_Public_Void_Boolean_0;

		// Token: 0x040053C6 RID: 21446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
