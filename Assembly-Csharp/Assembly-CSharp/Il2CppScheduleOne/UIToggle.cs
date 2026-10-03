using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B8 RID: 184
	public class UIToggle : UIOption
	{
		// Token: 0x060010A4 RID: 4260 RVA: 0x000B2C64 File Offset: 0x000B0E64
		// Note: this type is marked as 'beforefieldinit'.
		static UIToggle()
		{
			Il2CppClassPointerStore<UIToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIToggle>.NativeClassPtr);
			UIToggle.NativeFieldInfoPtr_buttonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "buttonText");
			UIToggle.NativeFieldInfoPtr_toggleImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "toggleImage");
			UIToggle.NativeFieldInfoPtr_ONTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "ONTEXT");
			UIToggle.NativeFieldInfoPtr_OFFTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "OFFTEXT");
			UIToggle.NativeFieldInfoPtr_OnChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "OnChanged");
			UIToggle.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, "state");
			UIToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665399);
			UIToggle.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665400);
			UIToggle.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665401);
			UIToggle.NativeMethodInfoPtr_SetStateWithoutNotify_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665402);
			UIToggle.NativeMethodInfoPtr_SetStateInternal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665403);
			UIToggle.NativeMethodInfoPtr_SetButtonState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665404);
			UIToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665405);
			UIToggle.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIToggle>.NativeClassPtr, 100665406);
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x000B2DAC File Offset: 0x000B0FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85175, XrefRangeEnd = 85184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000B2DE8 File Offset: 0x000B0FE8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIToggle.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x000B2E24 File Offset: 0x000B1024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85184, XrefRangeEnd = 85188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000B2E64 File Offset: 0x000B1064
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 85189, RefRangeEnd = 85197, XrefRangeStart = 85188, XrefRangeEnd = 85189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateWithoutNotify(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr_SetStateWithoutNotify_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000B2EA4 File Offset: 0x000B10A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85203, RefRangeEnd = 85206, XrefRangeStart = 85197, XrefRangeEnd = 85203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateInternal(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr_SetStateInternal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000B2EE4 File Offset: 0x000B10E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85206, XrefRangeEnd = 85212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonState(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr_SetButtonState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x000B2F24 File Offset: 0x000B1124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85212, XrefRangeEnd = 85213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x000B2F60 File Offset: 0x000B1160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85213, XrefRangeEnd = 85217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIToggle.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00009B45 File Offset: 0x00007D45
		public UIToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x000B2F94 File Offset: 0x000B1194
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x00009B4E File Offset: 0x00007D4E
		public unsafe TextMeshProUGUI buttonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_buttonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_buttonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x000B2FC4 File Offset: 0x000B11C4
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x00009B6D File Offset: 0x00007D6D
		public unsafe Image toggleImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_toggleImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_toggleImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x000B2FF4 File Offset: 0x000B11F4
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x00009B8C File Offset: 0x00007D8C
		public unsafe static string ONTEXT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIToggle.NativeFieldInfoPtr_ONTEXT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIToggle.NativeFieldInfoPtr_ONTEXT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x000B3014 File Offset: 0x000B1214
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00009B9E File Offset: 0x00007D9E
		public unsafe static string OFFTEXT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIToggle.NativeFieldInfoPtr_OFFTEXT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIToggle.NativeFieldInfoPtr_OFFTEXT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x000B3034 File Offset: 0x000B1234
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x00009BB0 File Offset: 0x00007DB0
		public unsafe UnityEvent<bool> OnChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_OnChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_OnChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x000B3064 File Offset: 0x000B1264
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00009BCF File Offset: 0x00007DCF
		public unsafe bool state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIToggle.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeFieldInfoPtr_buttonText;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeFieldInfoPtr_toggleImage;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeFieldInfoPtr_ONTEXT;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_OFFTEXT;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_OnChanged;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_SetStateWithoutNotify_Public_Void_Boolean_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_SetStateInternal_Private_Void_Boolean_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonState_Private_Void_Boolean_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0;
	}
}
