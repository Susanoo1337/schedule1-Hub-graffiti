using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005F1 RID: 1521
	public class HealthPreset : ValueProviderScriptableObject<Health>
	{
		// Token: 0x0600953D RID: 38205 RVA: 0x00284648 File Offset: 0x00282848
		// Note: this type is marked as 'beforefieldinit'.
		static HealthPreset()
		{
			Il2CppClassPointerStore<HealthPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "HealthPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthPreset>.NativeClassPtr);
			HealthPreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthPreset>.NativeClassPtr, "value");
			HealthPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthPreset>.NativeClassPtr, 100682811);
			HealthPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HealthPreset>.NativeClassPtr, 100682812);
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x002846B4 File Offset: 0x002828B4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Health GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HealthPreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Health_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Health>(intPtr3) : null;
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x00284700 File Offset: 0x00282900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272245, XrefRangeEnd = 272248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HealthPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HealthPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HealthPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x00045CCB File Offset: 0x00043ECB
		public HealthPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x0028473C File Offset: 0x0028293C
		// (set) Token: 0x06009542 RID: 38210 RVA: 0x00045CD4 File Offset: 0x00043ED4
		public unsafe Health value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthPreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Health>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HealthPreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066C9 RID: 26313
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066CA RID: 26314
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Health_0;

		// Token: 0x040066CB RID: 26315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
