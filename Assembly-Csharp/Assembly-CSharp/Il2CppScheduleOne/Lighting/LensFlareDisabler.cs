using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DB RID: 987
	public class LensFlareDisabler : MonoBehaviour
	{
		// Token: 0x0600585F RID: 22623 RVA: 0x001AD170 File Offset: 0x001AB370
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareDisabler()
		{
			Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LensFlareDisabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr);
			LensFlareDisabler.NativeFieldInfoPtr_RefreshDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, "RefreshDistance");
			LensFlareDisabler.NativeFieldInfoPtr_lensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, "lensFlare");
			LensFlareDisabler.NativeFieldInfoPtr_optimizedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, "optimizedLight");
			LensFlareDisabler.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, "threshold");
			LensFlareDisabler.NativeMethodInfoPtr_Awake_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, 100674904);
			LensFlareDisabler.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, 100674905);
			LensFlareDisabler.NativeMethodInfoPtr_Refresh_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, 100674906);
			LensFlareDisabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, 100674907);
			LensFlareDisabler.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr, 100674908);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x001AD254 File Offset: 0x001AB454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193035, XrefRangeEnd = 193075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDisabler.NativeMethodInfoPtr_Awake_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x001AD288 File Offset: 0x001AB488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193075, XrefRangeEnd = 193089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDisabler.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x001AD2BC File Offset: 0x001AB4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193089, XrefRangeEnd = 193102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDisabler.NativeMethodInfoPtr_Refresh_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x001AD2F0 File Offset: 0x001AB4F0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareDisabler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareDisabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDisabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x001AD32C File Offset: 0x001AB52C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193133, RefRangeEnd = 193134, XrefRangeStart = 193102, XrefRangeEnd = 193133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDisabler.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x00029C71 File Offset: 0x00027E71
		public LensFlareDisabler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005866 RID: 22630 RVA: 0x001AD360 File Offset: 0x001AB560
		// (set) Token: 0x06005867 RID: 22631 RVA: 0x00029C7A File Offset: 0x00027E7A
		public unsafe static int RefreshDistance
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LensFlareDisabler.NativeFieldInfoPtr_RefreshDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareDisabler.NativeFieldInfoPtr_RefreshDistance, (void*)(&value));
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x001AD37C File Offset: 0x001AB57C
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x00029C88 File Offset: 0x00027E88
		public unsafe LensFlareComponentSRP lensFlare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_lensFlare);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_lensFlare), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x001AD3AC File Offset: 0x001AB5AC
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x00029CA7 File Offset: 0x00027EA7
		public unsafe OptimizedLight optimizedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_optimizedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_optimizedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x001AD3DC File Offset: 0x001AB5DC
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x00029CC6 File Offset: 0x00027EC6
		public unsafe float threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_threshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDisabler.NativeFieldInfoPtr_threshold)) = value;
			}
		}

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeFieldInfoPtr_RefreshDistance;

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeFieldInfoPtr_lensFlare;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeFieldInfoPtr_optimizedLight;

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x04003CCD RID: 15565
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_1;

		// Token: 0x04003CCE RID: 15566
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_1;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
