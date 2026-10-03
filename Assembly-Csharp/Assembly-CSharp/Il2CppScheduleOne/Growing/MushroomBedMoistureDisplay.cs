using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000519 RID: 1305
	public class MushroomBedMoistureDisplay : GrowContainerMoistureDisplay
	{
		// Token: 0x06007677 RID: 30327 RVA: 0x00210024 File Offset: 0x0020E224
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedMoistureDisplay()
		{
			Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "MushroomBedMoistureDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr);
			MushroomBedMoistureDisplay.NativeFieldInfoPtr__tooHotIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr, "_tooHotIndicator");
			MushroomBedMoistureDisplay.NativeFieldInfoPtr__bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr, "_bed");
			MushroomBedMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr, 100678529);
			MushroomBedMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr, 100678530);
			MushroomBedMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr, 100678531);
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x002100B8 File Offset: 0x0020E2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229969, XrefRangeEnd = 229975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedMoistureDisplay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x002100F4 File Offset: 0x0020E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229975, XrefRangeEnd = 229983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCanvasContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedMoistureDisplay.NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00210130 File Offset: 0x0020E330
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedMoistureDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedMoistureDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedMoistureDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x000388B7 File Offset: 0x00036AB7
		public MushroomBedMoistureDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x0021016C File Offset: 0x0020E36C
		// (set) Token: 0x0600767D RID: 30333 RVA: 0x000388C0 File Offset: 0x00036AC0
		public unsafe GameObject _tooHotIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedMoistureDisplay.NativeFieldInfoPtr__tooHotIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedMoistureDisplay.NativeFieldInfoPtr__tooHotIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x0600767E RID: 30334 RVA: 0x0021019C File Offset: 0x0020E39C
		// (set) Token: 0x0600767F RID: 30335 RVA: 0x000388DF File Offset: 0x00036ADF
		public unsafe MushroomBed _bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedMoistureDisplay.NativeFieldInfoPtr__bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedMoistureDisplay.NativeFieldInfoPtr__bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050B3 RID: 20659
		private static readonly IntPtr NativeFieldInfoPtr__tooHotIndicator;

		// Token: 0x040050B4 RID: 20660
		private static readonly IntPtr NativeFieldInfoPtr__bed;

		// Token: 0x040050B5 RID: 20661
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040050B6 RID: 20662
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvasContents_Protected_Virtual_Void_0;

		// Token: 0x040050B7 RID: 20663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
