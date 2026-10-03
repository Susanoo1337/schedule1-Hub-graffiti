using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FD RID: 1533
	public class VoicePreset : ValueProviderScriptableObject<Voice>
	{
		// Token: 0x060095A7 RID: 38311 RVA: 0x002857A4 File Offset: 0x002839A4
		// Note: this type is marked as 'beforefieldinit'.
		static VoicePreset()
		{
			Il2CppClassPointerStore<VoicePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "VoicePreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoicePreset>.NativeClassPtr);
			VoicePreset.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoicePreset>.NativeClassPtr, "value");
			VoicePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Voice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoicePreset>.NativeClassPtr, 100682836);
			VoicePreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoicePreset>.NativeClassPtr, 100682837);
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x00285810 File Offset: 0x00283A10
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Voice GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoicePreset.NativeMethodInfoPtr_GetValue_Public_Virtual_Voice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Voice>(intPtr3) : null;
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x0028585C File Offset: 0x00283A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272314, XrefRangeEnd = 272317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoicePreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoicePreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoicePreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x00046072 File Offset: 0x00044272
		public VoicePreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x060095AB RID: 38315 RVA: 0x00285898 File Offset: 0x00283A98
		// (set) Token: 0x060095AC RID: 38316 RVA: 0x0004607B File Offset: 0x0004427B
		public unsafe Voice value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoicePreset.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Voice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoicePreset.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066FE RID: 26366
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040066FF RID: 26367
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Voice_0;

		// Token: 0x04006700 RID: 26368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
