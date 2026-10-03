using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000034 RID: 52
	public class LandingButtons : MonoBehaviour
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00084F44 File Offset: 0x00083144
		// Note: this type is marked as 'beforefieldinit'.
		static LandingButtons()
		{
			Il2CppClassPointerStore<LandingButtons>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingButtons");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr);
			LandingButtons.NativeFieldInfoPtr__landingSpotController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "_landingSpotController");
			LandingButtons.NativeFieldInfoPtr__flockController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "_flockController");
			LandingButtons.NativeFieldInfoPtr_hSliderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, "hSliderValue");
			LandingButtons.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, 100663616);
			LandingButtons.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr, 100663617);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00084FD8 File Offset: 0x000831D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68086, XrefRangeEnd = 68156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingButtons.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0008500C File Offset: 0x0008320C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68156, XrefRangeEnd = 68157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingButtons() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingButtons>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingButtons.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003E16 File Offset: 0x00002016
		public LandingButtons(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00085048 File Offset: 0x00083248
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003E1F File Offset: 0x0000201F
		public unsafe LandingSpotController _landingSpotController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__landingSpotController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__landingSpotController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00085078 File Offset: 0x00083278
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003E3E File Offset: 0x0000203E
		public unsafe FlockController _flockController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__flockController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr__flockController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000359 RID: 857 RVA: 0x000850A8 File Offset: 0x000832A8
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00003E5D File Offset: 0x0000205D
		public unsafe float hSliderValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr_hSliderValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingButtons.NativeFieldInfoPtr_hSliderValue)) = value;
			}
		}

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr__landingSpotController;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr__flockController;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_hSliderValue;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
