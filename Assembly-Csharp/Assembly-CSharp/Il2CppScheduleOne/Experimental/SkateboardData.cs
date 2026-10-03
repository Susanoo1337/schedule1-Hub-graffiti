using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F0 RID: 1776
	public class SkateboardData : ScriptableObject
	{
		// Token: 0x0600AB28 RID: 43816 RVA: 0x002D24D8 File Offset: 0x002D06D8
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardData()
		{
			Il2CppClassPointerStore<SkateboardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "SkateboardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardData>.NativeClassPtr);
			SkateboardData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardData>.NativeClassPtr, "Settings");
			SkateboardData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardData>.NativeClassPtr, 100685960);
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x002D2530 File Offset: 0x002D0730
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x0004E0D8 File Offset: 0x0004C2D8
		public SkateboardData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x002D256C File Offset: 0x002D076C
		// (set) Token: 0x0600AB2C RID: 43820 RVA: 0x0004E0E1 File Offset: 0x0004C2E1
		public unsafe SkateboardSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007642 RID: 30274
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04007643 RID: 30275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
