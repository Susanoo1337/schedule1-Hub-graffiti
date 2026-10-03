using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020005E5 RID: 1509
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x060094BF RID: 38079 RVA: 0x00282DF4 File Offset: 0x00280FF4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCUnlockTracker()
		{
			Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCUnlockTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr);
			NPCUnlockTracker.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "Npc");
			NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "onUnlocked");
			NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100682750);
			NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100682751);
			NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100682752);
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x00282E88 File Offset: 0x00281088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271999, XrefRangeEnd = 272008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x00282EBC File Offset: 0x002810BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00282F08 File Offset: 0x00281108
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCUnlockTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x0004592B File Offset: 0x00043B2B
		public NPCUnlockTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x060094C4 RID: 38084 RVA: 0x00282F44 File Offset: 0x00281144
		// (set) Token: 0x060094C5 RID: 38085 RVA: 0x00045934 File Offset: 0x00043B34
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x060094C6 RID: 38086 RVA: 0x00282F74 File Offset: 0x00281174
		// (set) Token: 0x060094C7 RID: 38087 RVA: 0x00045953 File Offset: 0x00043B53
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400667F RID: 26239
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x04006680 RID: 26240
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04006681 RID: 26241
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006682 RID: 26242
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04006683 RID: 26243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
