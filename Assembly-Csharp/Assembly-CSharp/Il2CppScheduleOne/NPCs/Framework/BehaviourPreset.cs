using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005ED RID: 1517
	public class BehaviourPreset : ValueProviderScriptableObject<Behaviour>
	{
		// Token: 0x0600951F RID: 38175 RVA: 0x00284124 File Offset: 0x00282324
		// Note: this type is marked as 'beforefieldinit'.
		static BehaviourPreset()
		{
			Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "BehaviourPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr);
			BehaviourPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr, "value");
			BehaviourPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr, 100682803);
			BehaviourPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr, 100682804);
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x00284190 File Offset: 0x00282390
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Behaviour GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BehaviourPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Behaviour_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x002841DC File Offset: 0x002823DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272229, XrefRangeEnd = 272232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BehaviourPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviourPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BehaviourPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x00045BDE File Offset: 0x00043DDE
		public BehaviourPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x00284218 File Offset: 0x00282418
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x00045BE7 File Offset: 0x00043DE7
		public unsafe Behaviour value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BehaviourPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BehaviourPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066BA RID: 26298
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066BB RID: 26299
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Behaviour_0;

		// Token: 0x040066BC RID: 26300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
