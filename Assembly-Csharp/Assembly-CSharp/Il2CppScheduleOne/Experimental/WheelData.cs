using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F3 RID: 1779
	public class WheelData : ScriptableObject
	{
		// Token: 0x0600AB90 RID: 43920 RVA: 0x002D3288 File Offset: 0x002D1488
		// Note: this type is marked as 'beforefieldinit'.
		static WheelData()
		{
			Il2CppClassPointerStore<WheelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "WheelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelData>.NativeClassPtr);
			WheelData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelData>.NativeClassPtr, "Settings");
			WheelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelData>.NativeClassPtr, 100685966);
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x002D32E0 File Offset: 0x002D14E0
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x0004E5F5 File Offset: 0x0004C7F5
		public WheelData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600AB93 RID: 43923 RVA: 0x002D331C File Offset: 0x002D151C
		// (set) Token: 0x0600AB94 RID: 43924 RVA: 0x0004E5FE File Offset: 0x0004C7FE
		public unsafe VehicleSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007676 RID: 30326
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04007677 RID: 30327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
