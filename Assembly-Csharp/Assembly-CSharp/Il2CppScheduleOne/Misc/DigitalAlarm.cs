using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002FC RID: 764
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x06003C60 RID: 15456 RVA: 0x001468A4 File Offset: 0x00144AA4
		// Note: this type is marked as 'beforefieldinit'.
		static DigitalAlarm()
		{
			Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "DigitalAlarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr);
			DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FLASH_FREQUENCY");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMesh");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMeshMaterialIndex");
			DigitalAlarm.NativeFieldInfoPtr_ScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenText");
			DigitalAlarm.NativeFieldInfoPtr_FlashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FlashScreen");
			DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "DisplayCurrentTime");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOffMat");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOnMat");
			DigitalAlarm.NativeFieldInfoPtr_isLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "isLit");
			DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671012);
			DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671013);
			DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671014);
			DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671015);
			DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671016);
			DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671017);
			DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671018);
			DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100671019);
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00146A28 File Offset: 0x00144C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151045, XrefRangeEnd = 151067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00146A5C File Offset: 0x00144C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151067, XrefRangeEnd = 151086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00146A90 File Offset: 0x00144C90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 151090, RefRangeEnd = 151095, XrefRangeStart = 151086, XrefRangeEnd = 151090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreenLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00146AD0 File Offset: 0x00144CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151098, RefRangeEnd = 151100, XrefRangeStart = 151095, XrefRangeEnd = 151098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00146B14 File Offset: 0x00144D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151110, RefRangeEnd = 151113, XrefRangeStart = 151100, XrefRangeEnd = 151110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayMinutes(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00146B54 File Offset: 0x00144D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151113, XrefRangeEnd = 151123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00146B88 File Offset: 0x00144D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151123, XrefRangeEnd = 151129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00146BBC File Offset: 0x00144DBC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalAlarm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x0001E260 File Offset: 0x0001C460
		public DigitalAlarm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06003C6A RID: 15466 RVA: 0x00146BF8 File Offset: 0x00144DF8
		// (set) Token: 0x06003C6B RID: 15467 RVA: 0x0001E269 File Offset: 0x0001C469
		public unsafe static float FLASH_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x00146C14 File Offset: 0x00144E14
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x0001E277 File Offset: 0x0001C477
		public unsafe MeshRenderer ScreenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x00146C44 File Offset: 0x00144E44
		// (set) Token: 0x06003C6F RID: 15471 RVA: 0x0001E296 File Offset: 0x0001C496
		public unsafe int ScreenMeshMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex)) = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x00146C6C File Offset: 0x00144E6C
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x0001E2B1 File Offset: 0x0001C4B1
		public unsafe TextMeshPro ScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x00146C9C File Offset: 0x00144E9C
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		public unsafe bool FlashScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen)) = value;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06003C74 RID: 15476 RVA: 0x00146CC4 File Offset: 0x00144EC4
		// (set) Token: 0x06003C75 RID: 15477 RVA: 0x0001E2EB File Offset: 0x0001C4EB
		public unsafe bool DisplayCurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime)) = value;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x00146CEC File Offset: 0x00144EEC
		// (set) Token: 0x06003C77 RID: 15479 RVA: 0x0001E306 File Offset: 0x0001C506
		public unsafe Material ScreenOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06003C78 RID: 15480 RVA: 0x00146D1C File Offset: 0x00144F1C
		// (set) Token: 0x06003C79 RID: 15481 RVA: 0x0001E325 File Offset: 0x0001C525
		public unsafe Material ScreenOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x00146D4C File Offset: 0x00144F4C
		// (set) Token: 0x06003C7B RID: 15483 RVA: 0x0001E344 File Offset: 0x0001C544
		public unsafe bool isLit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_isLit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_isLit)) = value;
			}
		}

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeFieldInfoPtr_FLASH_FREQUENCY;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMesh;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMeshMaterialIndex;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeFieldInfoPtr_ScreenText;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeFieldInfoPtr_FlashScreen;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeFieldInfoPtr_DisplayCurrentTime;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOffMat;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOnMat;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeFieldInfoPtr_isLit;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeMethodInfoPtr_DisplayText_Public_Void_String_0;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
