using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F3 RID: 1523
	public class InteractionPreset : ValueProviderScriptableObject<Interaction>
	{
		// Token: 0x06009549 RID: 38217 RVA: 0x0028487C File Offset: 0x00282A7C
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionPreset()
		{
			Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "InteractionPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr);
			InteractionPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr, "value");
			InteractionPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Interaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr, 100682815);
			InteractionPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr, 100682816);
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x002848E8 File Offset: 0x00282AE8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Interaction GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Interaction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interaction>(intPtr3) : null;
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00284934 File Offset: 0x00282B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272252, XrefRangeEnd = 272255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x00045D17 File Offset: 0x00043F17
		public InteractionPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600954D RID: 38221 RVA: 0x00284970 File Offset: 0x00282B70
		// (set) Token: 0x0600954E RID: 38222 RVA: 0x00045D20 File Offset: 0x00043F20
		public unsafe Interaction value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interaction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066CF RID: 26319
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066D0 RID: 26320
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Interaction_0;

		// Token: 0x040066D1 RID: 26321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
