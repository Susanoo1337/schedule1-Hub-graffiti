using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002C RID: 44
	public class UnluckDistanceDisabler : MonoBehaviour
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00081D7C File Offset: 0x0007FF7C
		// Note: this type is marked as 'beforefieldinit'.
		static UnluckDistanceDisabler()
		{
			Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnluckDistanceDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr);
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceDisable");
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceFrom");
			UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_distanceFromMainCam");
			UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_disableCheckInterval");
			UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_enableCheckInterval");
			UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, "_disableOnStart");
			UnluckDistanceDisabler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663555);
			UnluckDistanceDisabler.NativeMethodInfoPtr_DisableOnStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663556);
			UnluckDistanceDisabler.NativeMethodInfoPtr_CheckDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663557);
			UnluckDistanceDisabler.NativeMethodInfoPtr_CheckEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663558);
			UnluckDistanceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr, 100663559);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00081E88 File Offset: 0x00080088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67410, XrefRangeEnd = 67425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00081EBC File Offset: 0x000800BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67425, XrefRangeEnd = 67427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableOnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_DisableOnStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00081EF0 File Offset: 0x000800F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67427, XrefRangeEnd = 67434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_CheckDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00081F24 File Offset: 0x00080124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67434, XrefRangeEnd = 67441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr_CheckEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00081F58 File Offset: 0x00080158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67441, XrefRangeEnd = 67442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnluckDistanceDisabler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnluckDistanceDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnluckDistanceDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00003016 File Offset: 0x00001216
		public UnluckDistanceDisabler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00081F94 File Offset: 0x00080194
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000301F File Offset: 0x0000121F
		public unsafe int _distanceDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceDisable)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00081FBC File Offset: 0x000801BC
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000303A File Offset: 0x0000123A
		public unsafe Transform _distanceFrom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFrom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00081FEC File Offset: 0x000801EC
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00003059 File Offset: 0x00001259
		public unsafe bool _distanceFromMainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__distanceFromMainCam)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00082014 File Offset: 0x00080214
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00003074 File Offset: 0x00001274
		public unsafe float _disableCheckInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableCheckInterval)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0008203C File Offset: 0x0008023C
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000308F File Offset: 0x0000128F
		public unsafe float _enableCheckInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__enableCheckInterval)) = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00082064 File Offset: 0x00080264
		// (set) Token: 0x06000218 RID: 536 RVA: 0x000030AA File Offset: 0x000012AA
		public unsafe bool _disableOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnluckDistanceDisabler.NativeFieldInfoPtr__disableOnStart)) = value;
			}
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr__distanceDisable;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr__distanceFrom;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr__distanceFromMainCam;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr__disableCheckInterval;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr__enableCheckInterval;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr__disableOnStart;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_DisableOnStart_Public_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_CheckDisable_Public_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_CheckEnable_Public_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
