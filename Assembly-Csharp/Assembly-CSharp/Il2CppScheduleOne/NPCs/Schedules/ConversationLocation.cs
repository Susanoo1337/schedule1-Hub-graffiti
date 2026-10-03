using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x0200068E RID: 1678
	public class ConversationLocation : MonoBehaviour
	{
		// Token: 0x0600A32F RID: 41775 RVA: 0x002B6154 File Offset: 0x002B4354
		// Note: this type is marked as 'beforefieldinit'.
		static ConversationLocation()
		{
			Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "ConversationLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr);
			ConversationLocation.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "StandPoints");
			ConversationLocation.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "NPCs");
			ConversationLocation.NativeFieldInfoPtr_npcReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "npcReady");
			ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684871);
			ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684872);
			ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684873);
			ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684874);
			ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684875);
			ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, 100684876);
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600A330 RID: 41776 RVA: 0x002B6238 File Offset: 0x002B4438
		public unsafe bool NPCsReady
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286991, XrefRangeEnd = 287012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x002B6274 File Offset: 0x002B4474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287012, XrefRangeEnd = 287036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x002B62A8 File Offset: 0x002B44A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287036, XrefRangeEnd = 287044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetStandPoint(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x002B62F8 File Offset: 0x002B44F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287057, RefRangeEnd = 287060, XrefRangeStart = 287044, XrefRangeEnd = 287057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPCReady(NPC npc, bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ready;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x002B6348 File Offset: 0x002B4548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287060, XrefRangeEnd = 287086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC GetOtherNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x002B6398 File Offset: 0x002B4598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287086, XrefRangeEnd = 287101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConversationLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x0004ACD2 File Offset: 0x00048ED2
		public ConversationLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600A337 RID: 41783 RVA: 0x002B63D4 File Offset: 0x002B45D4
		// (set) Token: 0x0600A338 RID: 41784 RVA: 0x0004ACDB File Offset: 0x00048EDB
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x002B6404 File Offset: 0x002B4604
		// (set) Token: 0x0600A33A RID: 41786 RVA: 0x0004ACFA File Offset: 0x00048EFA
		public unsafe List<NPC> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600A33B RID: 41787 RVA: 0x002B6434 File Offset: 0x002B4634
		// (set) Token: 0x0600A33C RID: 41788 RVA: 0x0004AD19 File Offset: 0x00048F19
		public unsafe Dictionary<NPC, bool> npcReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPC, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.NativeFieldInfoPtr_npcReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040070BA RID: 28858
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x040070BB RID: 28859
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x040070BC RID: 28860
		private static readonly IntPtr NativeFieldInfoPtr_npcReady;

		// Token: 0x040070BD RID: 28861
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCsReady_Public_get_Boolean_0;

		// Token: 0x040070BE RID: 28862
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040070BF RID: 28863
		private static readonly IntPtr NativeMethodInfoPtr_GetStandPoint_Public_Transform_NPC_0;

		// Token: 0x040070C0 RID: 28864
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCReady_Public_Void_NPC_Boolean_0;

		// Token: 0x040070C1 RID: 28865
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNPC_Public_NPC_NPC_0;

		// Token: 0x040070C2 RID: 28866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C6E RID: 3182
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F186 RID: 61830 RVA: 0x003A4140 File Offset: 0x003A2340
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr);
				ConversationLocation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9");
				ConversationLocation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, "<>9__3_0");
				ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100684878);
				ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr, 100684879);
			}

			// Token: 0x0600F187 RID: 61831 RVA: 0x003A41BC File Offset: 0x003A23BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F188 RID: 61832 RVA: 0x003A41F8 File Offset: 0x003A23F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286972, XrefRangeEnd = 286973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NPCsReady_b__3_0(KeyValuePair<NPC, bool> npcReady)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(npcReady));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c.NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F189 RID: 61833 RVA: 0x00071FC3 File Offset: 0x000701C3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004950 RID: 18768
			// (get) Token: 0x0600F18A RID: 61834 RVA: 0x003A424C File Offset: 0x003A244C
			// (set) Token: 0x0600F18B RID: 61835 RVA: 0x00071FCC File Offset: 0x000701CC
			public unsafe static ConversationLocation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004951 RID: 18769
			// (get) Token: 0x0600F18C RID: 61836 RVA: 0x003A4274 File Offset: 0x003A2474
			// (set) Token: 0x0600F18D RID: 61837 RVA: 0x00071FDE File Offset: 0x000701DE
			public unsafe static Func<KeyValuePair<NPC, bool>, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<NPC, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConversationLocation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A380 RID: 41856
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A381 RID: 41857
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400A382 RID: 41858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A383 RID: 41859
			private static readonly IntPtr NativeMethodInfoPtr__get_NPCsReady_b__3_0_Internal_Boolean_KeyValuePair_2_NPC_Boolean_0;
		}

		// Token: 0x02000C6F RID: 3183
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.ConversationLocation+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F18E RID: 61838 RVA: 0x003A429C File Offset: 0x003A249C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationLocation>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr);
				ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, "npc");
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100684880);
				ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr, 100684881);
			}

			// Token: 0x0600F18F RID: 61839 RVA: 0x003A4304 File Offset: 0x003A2504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationLocation.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F190 RID: 61840 RVA: 0x003A4340 File Offset: 0x003A2540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286973, XrefRangeEnd = 286991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOtherNPC_b__0(NPC otherNPC)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherNPC);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConversationLocation.__c__DisplayClass8_0.NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F191 RID: 61841 RVA: 0x00071FF0 File Offset: 0x000701F0
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004952 RID: 18770
			// (get) Token: 0x0600F192 RID: 61842 RVA: 0x003A4390 File Offset: 0x003A2590
			// (set) Token: 0x0600F193 RID: 61843 RVA: 0x00071FF9 File Offset: 0x000701F9
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConversationLocation.__c__DisplayClass8_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A384 RID: 41860
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x0400A385 RID: 41861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A386 RID: 41862
			private static readonly IntPtr NativeMethodInfoPtr__GetOtherNPC_b__0_Internal_Boolean_NPC_0;
		}
	}
}
