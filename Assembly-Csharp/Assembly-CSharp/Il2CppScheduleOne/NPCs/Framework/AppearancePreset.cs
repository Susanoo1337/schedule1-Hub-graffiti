using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005E9 RID: 1513
	public class AppearancePreset : ValueProviderScriptableObject<Appearance>
	{
		// Token: 0x060094FB RID: 38139 RVA: 0x00283B54 File Offset: 0x00281D54
		// Note: this type is marked as 'beforefieldinit'.
		static AppearancePreset()
		{
			Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "AppearancePreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr);
			AppearancePreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr, "value");
			AppearancePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Appearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr, 100682795);
			AppearancePreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr, 100682796);
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x00283BC0 File Offset: 0x00281DC0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Appearance GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppearancePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Appearance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Appearance>(intPtr3) : null;
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00283C0C File Offset: 0x00281E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272211, XrefRangeEnd = 272214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppearancePreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppearancePreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppearancePreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00045A98 File Offset: 0x00043C98
		public AppearancePreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x060094FF RID: 38143 RVA: 0x00283C48 File Offset: 0x00281E48
		// (set) Token: 0x06009500 RID: 38144 RVA: 0x00045AA1 File Offset: 0x00043CA1
		public unsafe Appearance value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearancePreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Appearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppearancePreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066A8 RID: 26280
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066A9 RID: 26281
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Appearance_0;

		// Token: 0x040066AA RID: 26282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
