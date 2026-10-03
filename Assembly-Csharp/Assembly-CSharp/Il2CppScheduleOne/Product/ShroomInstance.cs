using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000566 RID: 1382
	[Serializable]
	public class ShroomInstance : ProductItemInstance
	{
		// Token: 0x06007E87 RID: 32391 RVA: 0x0022E528 File Offset: 0x0022C728
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomInstance()
		{
			Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ShroomInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr);
			ShroomInstance.NativeFieldInfoPtr__psychedelicEffectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, "_psychedelicEffectCoroutine");
			ShroomInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679629);
			ShroomInstance.NativeMethodInfoPtr_get__shroomDefinition_Private_get_ShroomDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679630);
			ShroomInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679631);
			ShroomInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679632);
			ShroomInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679633);
			ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679634);
			ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679635);
			ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679636);
			ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679637);
			ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToAvatar_Private_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679638);
			ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromAvatar_Private_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679639);
			ShroomInstance.NativeMethodInfoPtr_DoPsychedlicEffectBlend_Private_IEnumerator_MaterialProperties_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, 100679640);
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x0022E65C File Offset: 0x0022C85C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242080, XrefRangeEnd = 242087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x06007E89 RID: 32393 RVA: 0x0022E6A0 File Offset: 0x0022C8A0
		public unsafe ShroomDefinition _shroomDefinition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242087, XrefRangeEnd = 242090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance.NativeMethodInfoPtr_get__shroomDefinition_Private_get_ShroomDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0022E6E0 File Offset: 0x0022C8E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236035, RefRangeEnd = 236039, XrefRangeStart = 236035, XrefRangeEnd = 236039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0022E75C File Offset: 0x0022C95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242090, XrefRangeEnd = 242096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0022E7B4 File Offset: 0x0022C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242096, XrefRangeEnd = 242104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0022E800 File Offset: 0x0022CA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242104, XrefRangeEnd = 242107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x0022E850 File Offset: 0x0022CA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242107, XrefRangeEnd = 242113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x0022E8A0 File Offset: 0x0022CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242113, XrefRangeEnd = 242162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x0022E8F0 File Offset: 0x0022CAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242162, XrefRangeEnd = 242214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearEffectsFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0022E940 File Offset: 0x0022CB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242223, RefRangeEnd = 242225, XrefRangeStart = 242214, XrefRangeEnd = 242223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffectsToAvatar(Il2CppScheduleOne.AvatarFramework.Avatar avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance.NativeMethodInfoPtr_ApplyEffectsToAvatar_Private_Void_Avatar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0022E984 File Offset: 0x0022CB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242225, XrefRangeEnd = 242230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEffectsFromAvatar(Il2CppScheduleOne.AvatarFramework.Avatar avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance.NativeMethodInfoPtr_ClearEffectsFromAvatar_Private_Void_Avatar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x0022E9C8 File Offset: 0x0022CBC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242235, RefRangeEnd = 242237, XrefRangeStart = 242230, XrefRangeEnd = 242235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoPsychedlicEffectBlend(PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties, float targetValuePercentage, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetMaterialProperties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValuePercentage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance.NativeMethodInfoPtr_DoPsychedlicEffectBlend_Private_IEnumerator_MaterialProperties_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0003C091 File Offset: 0x0003A291
		public ShroomInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06007E95 RID: 32405 RVA: 0x0022EA34 File Offset: 0x0022CC34
		// (set) Token: 0x06007E96 RID: 32406 RVA: 0x0003C09A File Offset: 0x0003A29A
		public unsafe static Coroutine _psychedelicEffectCoroutine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShroomInstance.NativeFieldInfoPtr__psychedelicEffectCoroutine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomInstance.NativeFieldInfoPtr__psychedelicEffectCoroutine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400566A RID: 22122
		private static readonly IntPtr NativeFieldInfoPtr__psychedelicEffectCoroutine;

		// Token: 0x0400566B RID: 22123
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400566C RID: 22124
		private static readonly IntPtr NativeMethodInfoPtr_get__shroomDefinition_Private_get_ShroomDefinition_0;

		// Token: 0x0400566D RID: 22125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x0400566E RID: 22126
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400566F RID: 22127
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005670 RID: 22128
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005671 RID: 22129
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04005672 RID: 22130
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04005673 RID: 22131
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04005674 RID: 22132
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToAvatar_Private_Void_Avatar_0;

		// Token: 0x04005675 RID: 22133
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromAvatar_Private_Void_Avatar_0;

		// Token: 0x04005676 RID: 22134
		private static readonly IntPtr NativeMethodInfoPtr_DoPsychedlicEffectBlend_Private_IEnumerator_MaterialProperties_Single_Single_0;

		// Token: 0x02000BDE RID: 3038
		[ObfuscatedName("ScheduleOne.Product.ShroomInstance+<DoPsychedlicEffectBlend>d__14")]
		public sealed class _DoPsychedlicEffectBlend_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600EC5A RID: 60506 RVA: 0x00394D00 File Offset: 0x00392F00
			// Note: this type is marked as 'beforefieldinit'.
			static _DoPsychedlicEffectBlend_d__14()
			{
				Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShroomInstance>.NativeClassPtr, "<DoPsychedlicEffectBlend>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<>1__state");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<>2__current");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetValuePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "targetValuePercentage");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "duration");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "targetMaterialProperties");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__elapsed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<elapsed>5__2");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__activeProperties_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<activeProperties>5__3");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__sourceProperties_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<sourceProperties>5__4");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__startValue_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, "<startValue>5__5");
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679641);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679642);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679643);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679644);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679645);
				ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr, 100679646);
			}

			// Token: 0x0600EC5B RID: 60507 RVA: 0x00394E58 File Offset: 0x00393058
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoPsychedlicEffectBlend_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomInstance._DoPsychedlicEffectBlend_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC5C RID: 60508 RVA: 0x00394EA0 File Offset: 0x003930A0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC5D RID: 60509 RVA: 0x00394ED4 File Offset: 0x003930D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242037, XrefRangeEnd = 242075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047AF RID: 18351
			// (get) Token: 0x0600EC5E RID: 60510 RVA: 0x00394F10 File Offset: 0x00393110
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC5F RID: 60511 RVA: 0x00394F50 File Offset: 0x00393150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242075, XrefRangeEnd = 242080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047B0 RID: 18352
			// (get) Token: 0x0600EC60 RID: 60512 RVA: 0x00394F84 File Offset: 0x00393184
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC61 RID: 60513 RVA: 0x0006F7BC File Offset: 0x0006D9BC
			public _DoPsychedlicEffectBlend_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A6 RID: 18342
			// (get) Token: 0x0600EC62 RID: 60514 RVA: 0x00394FC4 File Offset: 0x003931C4
			// (set) Token: 0x0600EC63 RID: 60515 RVA: 0x0006F7C5 File Offset: 0x0006D9C5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047A7 RID: 18343
			// (get) Token: 0x0600EC64 RID: 60516 RVA: 0x00394FEC File Offset: 0x003931EC
			// (set) Token: 0x0600EC65 RID: 60517 RVA: 0x0006F7E0 File Offset: 0x0006D9E0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A8 RID: 18344
			// (get) Token: 0x0600EC66 RID: 60518 RVA: 0x0039501C File Offset: 0x0039321C
			// (set) Token: 0x0600EC67 RID: 60519 RVA: 0x0006F7FF File Offset: 0x0006D9FF
			public unsafe float targetValuePercentage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetValuePercentage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetValuePercentage)) = value;
				}
			}

			// Token: 0x170047A9 RID: 18345
			// (get) Token: 0x0600EC68 RID: 60520 RVA: 0x00395044 File Offset: 0x00393244
			// (set) Token: 0x0600EC69 RID: 60521 RVA: 0x0006F81A File Offset: 0x0006DA1A
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170047AA RID: 18346
			// (get) Token: 0x0600EC6A RID: 60522 RVA: 0x0039506C File Offset: 0x0039326C
			// (set) Token: 0x0600EC6B RID: 60523 RVA: 0x0006F835 File Offset: 0x0006DA35
			public unsafe PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetMaterialProperties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr_targetMaterialProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AB RID: 18347
			// (get) Token: 0x0600EC6C RID: 60524 RVA: 0x0039509C File Offset: 0x0039329C
			// (set) Token: 0x0600EC6D RID: 60525 RVA: 0x0006F854 File Offset: 0x0006DA54
			public unsafe float _elapsed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__elapsed_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__elapsed_5__2)) = value;
				}
			}

			// Token: 0x170047AC RID: 18348
			// (get) Token: 0x0600EC6E RID: 60526 RVA: 0x003950C4 File Offset: 0x003932C4
			// (set) Token: 0x0600EC6F RID: 60527 RVA: 0x0006F86F File Offset: 0x0006DA6F
			public unsafe PsychedelicFullScreenFeature.MaterialProperties _activeProperties_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__activeProperties_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__activeProperties_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AD RID: 18349
			// (get) Token: 0x0600EC70 RID: 60528 RVA: 0x003950F4 File Offset: 0x003932F4
			// (set) Token: 0x0600EC71 RID: 60529 RVA: 0x0006F88E File Offset: 0x0006DA8E
			public unsafe PsychedelicFullScreenFeature.MaterialProperties _sourceProperties_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__sourceProperties_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__sourceProperties_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047AE RID: 18350
			// (get) Token: 0x0600EC72 RID: 60530 RVA: 0x00395124 File Offset: 0x00393324
			// (set) Token: 0x0600EC73 RID: 60531 RVA: 0x0006F8AD File Offset: 0x0006DAAD
			public unsafe float _startValue_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__startValue_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomInstance._DoPsychedlicEffectBlend_d__14.NativeFieldInfoPtr__startValue_5__5)) = value;
				}
			}

			// Token: 0x0400A002 RID: 40962
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A003 RID: 40963
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A004 RID: 40964
			private static readonly IntPtr NativeFieldInfoPtr_targetValuePercentage;

			// Token: 0x0400A005 RID: 40965
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A006 RID: 40966
			private static readonly IntPtr NativeFieldInfoPtr_targetMaterialProperties;

			// Token: 0x0400A007 RID: 40967
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__2;

			// Token: 0x0400A008 RID: 40968
			private static readonly IntPtr NativeFieldInfoPtr__activeProperties_5__3;

			// Token: 0x0400A009 RID: 40969
			private static readonly IntPtr NativeFieldInfoPtr__sourceProperties_5__4;

			// Token: 0x0400A00A RID: 40970
			private static readonly IntPtr NativeFieldInfoPtr__startValue_5__5;

			// Token: 0x0400A00B RID: 40971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A00C RID: 40972
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A00D RID: 40973
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A00E RID: 40974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A00F RID: 40975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A010 RID: 40976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
