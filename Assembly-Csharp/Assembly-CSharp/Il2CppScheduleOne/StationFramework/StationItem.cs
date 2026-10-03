using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000545 RID: 1349
	public class StationItem : MonoBehaviour
	{
		// Token: 0x06007B75 RID: 31605 RVA: 0x00221F50 File Offset: 0x00220150
		// Note: this type is marked as 'beforefieldinit'.
		static StationItem()
		{
			Il2CppClassPointerStore<StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem>.NativeClassPtr);
			StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<ActiveModules>k__BackingField");
			StationItem.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "Modules");
			StationItem.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "TrashPrefab");
			StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679155);
			StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679156);
			StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679157);
			StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679158);
			StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679159);
			StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679160);
			StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679161);
			StationItem.NativeMethodInfoPtr_GetModule_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679162);
			StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem>.NativeClassPtr, 100679163);
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06007B76 RID: 31606 RVA: 0x00222070 File Offset: 0x00220270
		// (set) Token: 0x06007B77 RID: 31607 RVA: 0x002220B0 File Offset: 0x002202B0
		public unsafe List<ItemModule> ActiveModules
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x002220F4 File Offset: 0x002202F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235594, XrefRangeEnd = 235599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x00222130 File Offset: 0x00220330
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x00222180 File Offset: 0x00220380
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 235621, RefRangeEnd = 235629, XrefRangeStart = 235599, XrefRangeEnd = 235621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x002221B4 File Offset: 0x002203B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 235634, RefRangeEnd = 235643, XrefRangeStart = 235629, XrefRangeEnd = 235634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x002221E8 File Offset: 0x002203E8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 235661, RefRangeEnd = 235673, XrefRangeStart = 235643, XrefRangeEnd = 235661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x00222224 File Offset: 0x00220424
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 235691, RefRangeEnd = 235729, XrefRangeStart = 235673, XrefRangeEnd = 235691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetModule<T>() where T : ItemModule
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.MethodInfoStoreGeneric_GetModule_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x00222260 File Offset: 0x00220460
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 235737, RefRangeEnd = 235742, XrefRangeStart = 235729, XrefRangeEnd = 235737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0003ACE2 File Offset: 0x00038EE2
		public StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06007B80 RID: 31616 RVA: 0x0022229C File Offset: 0x0022049C
		// (set) Token: 0x06007B81 RID: 31617 RVA: 0x0003ACEB File Offset: 0x00038EEB
		public unsafe List<ItemModule> _ActiveModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr__ActiveModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x002222CC File Offset: 0x002204CC
		// (set) Token: 0x06007B83 RID: 31619 RVA: 0x0003AD0A File Offset: 0x00038F0A
		public unsafe List<ItemModule> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x002222FC File Offset: 0x002204FC
		// (set) Token: 0x06007B85 RID: 31621 RVA: 0x0003AD29 File Offset: 0x00038F29
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationItem.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005425 RID: 21541
		private static readonly IntPtr NativeFieldInfoPtr__ActiveModules_k__BackingField;

		// Token: 0x04005426 RID: 21542
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04005427 RID: 21543
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x04005428 RID: 21544
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveModules_Public_get_List_1_ItemModule_0;

		// Token: 0x04005429 RID: 21545
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveModules_Protected_set_Void_List_1_ItemModule_0;

		// Token: 0x0400542A RID: 21546
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400542B RID: 21547
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_StorableItemDefinition_0;

		// Token: 0x0400542C RID: 21548
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Void_0;

		// Token: 0x0400542D RID: 21549
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400542E RID: 21550
		private static readonly IntPtr NativeMethodInfoPtr_HasModule_Public_Boolean_0;

		// Token: 0x0400542F RID: 21551
		private static readonly IntPtr NativeMethodInfoPtr_GetModule_Public_T_0;

		// Token: 0x04005430 RID: 21552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBC RID: 3004
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600EB4B RID: 60235 RVA: 0x00391C2C File Offset: 0x0038FE2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr);
				StationItem.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9");
				StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679165);
				StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr, 100679166);
			}

			// Token: 0x0600EB4C RID: 60236 RVA: 0x00391CE4 File Offset: 0x0038FEE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB4D RID: 60237 RVA: 0x00391D20 File Offset: 0x0038FF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235577, XrefRangeEnd = 235584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasModule_b__10_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__10<T>.NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB4E RID: 60238 RVA: 0x0006F012 File Offset: 0x0006D212
			public __c__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004761 RID: 18273
			// (get) Token: 0x0600EB4F RID: 60239 RVA: 0x00391D70 File Offset: 0x0038FF70
			// (set) Token: 0x0600EB50 RID: 60240 RVA: 0x0006F01B File Offset: 0x0006D21B
			public unsafe static StationItem.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004762 RID: 18274
			// (get) Token: 0x0600EB51 RID: 60241 RVA: 0x00391D98 File Offset: 0x0038FF98
			// (set) Token: 0x0600EB52 RID: 60242 RVA: 0x0006F02D File Offset: 0x0006D22D
			public unsafe static Predicate<ItemModule> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F6F RID: 40815
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F70 RID: 40816
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009F71 RID: 40817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F72 RID: 40818
			private static readonly IntPtr NativeMethodInfoPtr__HasModule_b__10_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000BBD RID: 3005
		[ObfuscatedName("ScheduleOne.StationFramework.StationItem+<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Il2CppSystem.Object where T : ItemModule
		{
			// Token: 0x0600EB53 RID: 60243 RVA: 0x00391DC0 File Offset: 0x0038FFC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationItem>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr);
				StationItem.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9");
				StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679168);
				StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr, 100679169);
			}

			// Token: 0x0600EB54 RID: 60244 RVA: 0x00391E78 File Offset: 0x00390078
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationItem.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB55 RID: 60245 RVA: 0x00391EB4 File Offset: 0x003900B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235584, XrefRangeEnd = 235594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetModule_b__11_0(ItemModule x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationItem.__c__11<T>.NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB56 RID: 60246 RVA: 0x0006F03F File Offset: 0x0006D23F
			public __c__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004763 RID: 18275
			// (get) Token: 0x0600EB57 RID: 60247 RVA: 0x00391F04 File Offset: 0x00390104
			// (set) Token: 0x0600EB58 RID: 60248 RVA: 0x0006F048 File Offset: 0x0006D248
			public unsafe static StationItem.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004764 RID: 18276
			// (get) Token: 0x0600EB59 RID: 60249 RVA: 0x00391F2C File Offset: 0x0039012C
			// (set) Token: 0x0600EB5A RID: 60250 RVA: 0x0006F05A File Offset: 0x0006D25A
			public unsafe static Predicate<ItemModule> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemModule>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationItem.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F73 RID: 40819
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F74 RID: 40820
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009F75 RID: 40821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F76 RID: 40822
			private static readonly IntPtr NativeMethodInfoPtr__GetModule_b__11_0_Internal_Boolean_ItemModule_0;
		}

		// Token: 0x02000BBE RID: 3006
		private sealed class MethodInfoStoreGeneric_ActivateModule_Public_Void_0<T>
		{
			// Token: 0x04009F77 RID: 40823
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_ActivateModule_Public_Void_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BBF RID: 3007
		private sealed class MethodInfoStoreGeneric_HasModule_Public_Boolean_0<T>
		{
			// Token: 0x04009F78 RID: 40824
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_HasModule_Public_Boolean_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BC0 RID: 3008
		private sealed class MethodInfoStoreGeneric_GetModule_Public_T_0<T>
		{
			// Token: 0x04009F79 RID: 40825
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StationItem.NativeMethodInfoPtr_GetModule_Public_T_0, Il2CppClassPointerStore<StationItem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
