using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F2 RID: 754
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x06003BCC RID: 15308 RVA: 0x00144D84 File Offset: 0x00142F84
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementUtilities()
		{
			Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr);
			ManagementUtilities.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "Seeds");
			ManagementUtilities.NativeFieldInfoPtr_MushroomSpawns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "MushroomSpawns");
			ManagementUtilities.NativeFieldInfoPtr__StorageTypeIcon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "<StorageTypeIcon>k__BackingField");
			ManagementUtilities.NativeFieldInfoPtr__StorageUIElementPrefab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "<StorageUIElementPrefab>k__BackingField");
			ManagementUtilities.NativeMethodInfoPtr_get_StorageTypeIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670966);
			ManagementUtilities.NativeMethodInfoPtr_set_StorageTypeIcon_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670967);
			ManagementUtilities.NativeMethodInfoPtr_get_StorageUIElementPrefab_Public_get_StorageUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670968);
			ManagementUtilities.NativeMethodInfoPtr_set_StorageUIElementPrefab_Private_set_Void_StorageUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670969);
			ManagementUtilities.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670970);
			ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100670971);
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00144E7C File Offset: 0x0014307C
		// (set) Token: 0x06003BCE RID: 15310 RVA: 0x00144EBC File Offset: 0x001430BC
		public unsafe Sprite StorageTypeIcon
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_StorageTypeIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_set_StorageTypeIcon_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x00144F00 File Offset: 0x00143100
		// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x00144F40 File Offset: 0x00143140
		public unsafe StorageUIElement StorageUIElementPrefab
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_StorageUIElementPrefab_Public_get_StorageUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_set_StorageUIElementPrefab_Private_set_Void_StorageUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x00144F84 File Offset: 0x00143184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150615, XrefRangeEnd = 150618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementUtilities.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00144FC0 File Offset: 0x001431C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150618, XrefRangeEnd = 150635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementUtilities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0001DD61 File Offset: 0x0001BF61
		public ManagementUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06003BD4 RID: 15316 RVA: 0x00144FFC File Offset: 0x001431FC
		// (set) Token: 0x06003BD5 RID: 15317 RVA: 0x0001DD6A File Offset: 0x0001BF6A
		public unsafe List<SeedDefinition> Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SeedDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x0014502C File Offset: 0x0014322C
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x0001DD89 File Offset: 0x0001BF89
		public unsafe List<ShroomSpawnDefinition> MushroomSpawns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_MushroomSpawns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShroomSpawnDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_MushroomSpawns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x0014505C File Offset: 0x0014325C
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		public unsafe Sprite _StorageTypeIcon_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr__StorageTypeIcon_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr__StorageTypeIcon_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x0014508C File Offset: 0x0014328C
		// (set) Token: 0x06003BDB RID: 15323 RVA: 0x0001DDC7 File Offset: 0x0001BFC7
		public unsafe StorageUIElement _StorageUIElementPrefab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr__StorageUIElementPrefab_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr__StorageUIElementPrefab_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeFieldInfoPtr_MushroomSpawns;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeFieldInfoPtr__StorageTypeIcon_k__BackingField;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeFieldInfoPtr__StorageUIElementPrefab_k__BackingField;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeMethodInfoPtr_get_StorageTypeIcon_Public_get_Sprite_0;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeMethodInfoPtr_set_StorageTypeIcon_Private_set_Void_Sprite_0;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_get_StorageUIElementPrefab_Public_get_StorageUIElement_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr_set_StorageUIElementPrefab_Private_set_Void_StorageUIElement_0;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
