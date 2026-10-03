using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F6 RID: 1526
	[Serializable]
	public class Messaging : Object
	{
		// Token: 0x06009571 RID: 38257 RVA: 0x00284E80 File Offset: 0x00283080
		// Note: this type is marked as 'beforefieldinit'.
		static Messaging()
		{
			Il2CppClassPointerStore<Messaging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Messaging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Messaging>.NativeClassPtr);
			Messaging.NativeFieldInfoPtr_IsKnownByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Messaging>.NativeClassPtr, "IsKnownByDefault");
			Messaging.NativeFieldInfoPtr_ConversationCanBeHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Messaging>.NativeClassPtr, "ConversationCanBeHidden");
			Messaging.NativeFieldInfoPtr_ConversationCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Messaging>.NativeClassPtr, "ConversationCategories");
			Messaging.NativeMethodInfoPtr_GetCopy_Public_Messaging_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Messaging>.NativeClassPtr, 100682822);
			Messaging.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Messaging>.NativeClassPtr, 100682823);
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00284F14 File Offset: 0x00283114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272281, XrefRangeEnd = 272289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Messaging GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Messaging.NativeMethodInfoPtr_GetCopy_Public_Messaging_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Messaging>(intPtr3) : null;
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x00284F54 File Offset: 0x00283154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272289, XrefRangeEnd = 272290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Messaging() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Messaging>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Messaging.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x00045EC0 File Offset: 0x000440C0
		public Messaging(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E1E RID: 11806
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x00284F90 File Offset: 0x00283190
		// (set) Token: 0x06009576 RID: 38262 RVA: 0x00045EC9 File Offset: 0x000440C9
		public unsafe bool IsKnownByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_IsKnownByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_IsKnownByDefault)) = value;
			}
		}

		// Token: 0x17002E1F RID: 11807
		// (get) Token: 0x06009577 RID: 38263 RVA: 0x00284FB8 File Offset: 0x002831B8
		// (set) Token: 0x06009578 RID: 38264 RVA: 0x00045EE4 File Offset: 0x000440E4
		public unsafe bool ConversationCanBeHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_ConversationCanBeHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_ConversationCanBeHidden)) = value;
			}
		}

		// Token: 0x17002E20 RID: 11808
		// (get) Token: 0x06009579 RID: 38265 RVA: 0x00284FE0 File Offset: 0x002831E0
		// (set) Token: 0x0600957A RID: 38266 RVA: 0x00045EFF File Offset: 0x000440FF
		public unsafe Il2CppStructArray<EConversationCategory> ConversationCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_ConversationCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Messaging.NativeFieldInfoPtr_ConversationCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066E3 RID: 26339
		private static readonly IntPtr NativeFieldInfoPtr_IsKnownByDefault;

		// Token: 0x040066E4 RID: 26340
		private static readonly IntPtr NativeFieldInfoPtr_ConversationCanBeHidden;

		// Token: 0x040066E5 RID: 26341
		private static readonly IntPtr NativeFieldInfoPtr_ConversationCategories;

		// Token: 0x040066E6 RID: 26342
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Messaging_0;

		// Token: 0x040066E7 RID: 26343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
