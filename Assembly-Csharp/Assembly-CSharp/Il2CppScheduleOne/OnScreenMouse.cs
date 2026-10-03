using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009C RID: 156
	public class OnScreenMouse : Singleton<OnScreenMouse>
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x000A7FBC File Offset: 0x000A61BC
		// Note: this type is marked as 'beforefieldinit'.
		static OnScreenMouse()
		{
			Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "OnScreenMouse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr);
			OnScreenMouse.NativeFieldInfoPtr_CURSOR_COORDINATE_REFERENCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, "CURSOR_COORDINATE_REFERENCE");
			OnScreenMouse.NativeFieldInfoPtr_ptrComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, "ptrComponent");
			OnScreenMouse.NativeFieldInfoPtr_systemMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, "systemMouse");
			OnScreenMouse.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664994);
			OnScreenMouse.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664995);
			OnScreenMouse.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664996);
			OnScreenMouse.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664997);
			OnScreenMouse.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664998);
			OnScreenMouse.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100664999);
			OnScreenMouse.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100665000);
			OnScreenMouse.NativeMethodInfoPtr_SetTexture_Public_Void_Texture_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100665001);
			OnScreenMouse.NativeMethodInfoPtr_SetVirtualMouseEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100665002);
			OnScreenMouse.NativeMethodInfoPtr_UpdateSystemMouseValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100665003);
			OnScreenMouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr, 100665004);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000A8104 File Offset: 0x000A6304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79865, XrefRangeEnd = 79887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnScreenMouse.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000A8140 File Offset: 0x000A6340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79887, XrefRangeEnd = 79892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000A8180 File Offset: 0x000A6380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79892, XrefRangeEnd = 79916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x000A81B4 File Offset: 0x000A63B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79916, XrefRangeEnd = 79939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x000A81E8 File Offset: 0x000A63E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79939, XrefRangeEnd = 79956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000A821C File Offset: 0x000A641C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000A8250 File Offset: 0x000A6450
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000A8284 File Offset: 0x000A6484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79964, RefRangeEnd = 79965, XrefRangeStart = 79956, XrefRangeEnd = 79964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTexture(Texture tex, Vector2 hotSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hotSpot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_SetTexture_Public_Void_Texture_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000A82D4 File Offset: 0x000A64D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 79988, RefRangeEnd = 79991, XrefRangeStart = 79965, XrefRangeEnd = 79988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVirtualMouseEnabled(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_SetVirtualMouseEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000A8314 File Offset: 0x000A6514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSystemMouseValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr_UpdateSystemMouseValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x000A8348 File Offset: 0x000A6548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79991, XrefRangeEnd = 79994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnScreenMouse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnScreenMouse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnScreenMouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000081B9 File Offset: 0x000063B9
		public OnScreenMouse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000A8384 File Offset: 0x000A6584
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000081C2 File Offset: 0x000063C2
		public unsafe static Vector2 CURSOR_COORDINATE_REFERENCE
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(OnScreenMouse.NativeFieldInfoPtr_CURSOR_COORDINATE_REFERENCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnScreenMouse.NativeFieldInfoPtr_CURSOR_COORDINATE_REFERENCE, (void*)(&value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x000A83A0 File Offset: 0x000A65A0
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x000081D0 File Offset: 0x000063D0
		public unsafe VirtualMouseInput ptrComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenMouse.NativeFieldInfoPtr_ptrComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VirtualMouseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenMouse.NativeFieldInfoPtr_ptrComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000A83D0 File Offset: 0x000A65D0
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000081EF File Offset: 0x000063EF
		public unsafe Mouse systemMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenMouse.NativeFieldInfoPtr_systemMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnScreenMouse.NativeFieldInfoPtr_systemMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr_CURSOR_COORDINATE_REFERENCE;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr_ptrComponent;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr_systemMouse;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Texture_Vector2_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_SetVirtualMouseEnabled_Private_Void_Boolean_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSystemMouseValues_Private_Void_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
