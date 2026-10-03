using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200076C RID: 1900
	public class UIMover : MonoBehaviour
	{
		// Token: 0x0600B8F5 RID: 47349 RVA: 0x002FB4C4 File Offset: 0x002F96C4
		// Note: this type is marked as 'beforefieldinit'.
		static UIMover()
		{
			Il2CppClassPointerStore<UIMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UIMover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMover>.NativeClassPtr);
			UIMover.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "Rect");
			UIMover.NativeFieldInfoPtr_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MinSpeed");
			UIMover.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "MaxSpeed");
			UIMover.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "SpeedMultiplier");
			UIMover.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMover>.NativeClassPtr, "speed");
			UIMover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100687485);
			UIMover.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100687486);
			UIMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMover>.NativeClassPtr, 100687487);
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x002FB594 File Offset: 0x002F9794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309445, XrefRangeEnd = 309447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x002FB5C8 File Offset: 0x002F97C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309447, XrefRangeEnd = 309451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002FB5FC File Offset: 0x002F97FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309451, XrefRangeEnd = 309458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x000560A0 File Offset: 0x000542A0
		public UIMover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x002FB638 File Offset: 0x002F9838
		// (set) Token: 0x0600B8FB RID: 47355 RVA: 0x000560A9 File Offset: 0x000542A9
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x002FB668 File Offset: 0x002F9868
		// (set) Token: 0x0600B8FD RID: 47357 RVA: 0x000560C8 File Offset: 0x000542C8
		public unsafe Vector2 MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MinSpeed)) = value;
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600B8FE RID: 47358 RVA: 0x002FB690 File Offset: 0x002F9890
		// (set) Token: 0x0600B8FF RID: 47359 RVA: 0x000560E3 File Offset: 0x000542E3
		public unsafe Vector2 MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_MaxSpeed)) = value;
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600B900 RID: 47360 RVA: 0x002FB6B8 File Offset: 0x002F98B8
		// (set) Token: 0x0600B901 RID: 47361 RVA: 0x000560FE File Offset: 0x000542FE
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600B902 RID: 47362 RVA: 0x002FB6E0 File Offset: 0x002F98E0
		// (set) Token: 0x0600B903 RID: 47363 RVA: 0x00056119 File Offset: 0x00054319
		public unsafe Vector2 speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMover.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x04007EED RID: 32493
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007EEE RID: 32494
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeed;

		// Token: 0x04007EEF RID: 32495
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpeed;

		// Token: 0x04007EF0 RID: 32496
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04007EF1 RID: 32497
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04007EF2 RID: 32498
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007EF3 RID: 32499
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007EF4 RID: 32500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
