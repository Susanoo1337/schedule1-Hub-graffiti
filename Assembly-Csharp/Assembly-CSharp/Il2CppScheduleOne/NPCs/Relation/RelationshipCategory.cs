using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020005E2 RID: 1506
	public class RelationshipCategory : Il2CppSystem.Object
	{
		// Token: 0x0600947A RID: 38010 RVA: 0x00281EF0 File Offset: 0x002800F0
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipCategory()
		{
			Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "RelationshipCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr);
			RelationshipCategory.NativeFieldInfoPtr_Hostile_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Hostile_Color");
			RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Unfriendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Neutral_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Neutral_Color");
			RelationshipCategory.NativeFieldInfoPtr_Friendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Friendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Loyal_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Loyal_Color");
			RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100682709);
			RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100682710);
			RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100682711);
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x00281FC0 File Offset: 0x002801C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271761, RefRangeEnd = 271763, XrefRangeStart = 271761, XrefRangeEnd = 271761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERelationshipCategory GetCategory(float delta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00282000 File Offset: 0x00280200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271771, RefRangeEnd = 271772, XrefRangeStart = 271763, XrefRangeEnd = 271771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(ERelationshipCategory category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x00282040 File Offset: 0x00280240
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x000457C2 File Offset: 0x000439C2
		public RelationshipCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x0028207C File Offset: 0x0028027C
		// (set) Token: 0x06009480 RID: 38016 RVA: 0x000457CB File Offset: 0x000439CB
		public unsafe static Color32 Hostile_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&value));
			}
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x00282098 File Offset: 0x00280298
		// (set) Token: 0x06009482 RID: 38018 RVA: 0x000457D9 File Offset: 0x000439D9
		public unsafe static Color32 Unfriendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&value));
			}
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x06009483 RID: 38019 RVA: 0x002820B4 File Offset: 0x002802B4
		// (set) Token: 0x06009484 RID: 38020 RVA: 0x000457E7 File Offset: 0x000439E7
		public unsafe static Color32 Neutral_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&value));
			}
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x002820D0 File Offset: 0x002802D0
		// (set) Token: 0x06009486 RID: 38022 RVA: 0x000457F5 File Offset: 0x000439F5
		public unsafe static Color32 Friendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&value));
			}
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x002820EC File Offset: 0x002802EC
		// (set) Token: 0x06009488 RID: 38024 RVA: 0x00045803 File Offset: 0x00043A03
		public unsafe static Color32 Loyal_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&value));
			}
		}

		// Token: 0x0400664F RID: 26191
		private static readonly IntPtr NativeFieldInfoPtr_Hostile_Color;

		// Token: 0x04006650 RID: 26192
		private static readonly IntPtr NativeFieldInfoPtr_Unfriendly_Color;

		// Token: 0x04006651 RID: 26193
		private static readonly IntPtr NativeFieldInfoPtr_Neutral_Color;

		// Token: 0x04006652 RID: 26194
		private static readonly IntPtr NativeFieldInfoPtr_Friendly_Color;

		// Token: 0x04006653 RID: 26195
		private static readonly IntPtr NativeFieldInfoPtr_Loyal_Color;

		// Token: 0x04006654 RID: 26196
		private static readonly IntPtr NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0;

		// Token: 0x04006655 RID: 26197
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0;

		// Token: 0x04006656 RID: 26198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
