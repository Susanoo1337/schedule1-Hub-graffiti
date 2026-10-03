using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A4 RID: 164
	public class UIOption : MonoBehaviour
	{
		// Token: 0x06000E0C RID: 3596 RVA: 0x000AA0D8 File Offset: 0x000A82D8
		// Note: this type is marked as 'beforefieldinit'.
		static UIOption()
		{
			Il2CppClassPointerStore<UIOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIOption>.NativeClassPtr);
			UIOption.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "selectable");
			UIOption.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "nameText");
			UIOption.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "optionName");
			UIOption.NativeFieldInfoPtr_MoveThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "MoveThreshold");
			UIOption.NativeFieldInfoPtr_wasNavPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "wasNavPressedLastFrame");
			UIOption.NativeFieldInfoPtr_navTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "navTimer");
			UIOption.NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665073);
			UIOption.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665074);
			UIOption.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665075);
			UIOption.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665076);
			UIOption.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665077);
			UIOption.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665078);
			UIOption.NativeMethodInfoPtr_MoveRight_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665079);
			UIOption.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665080);
			UIOption.NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665081);
			UIOption.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIOption>.NativeClassPtr, 100665082);
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x000AA248 File Offset: 0x000A8448
		public unsafe virtual float NavigationRepeatRateMult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x000AA290 File Offset: 0x000A8490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80980, RefRangeEnd = 80983, XrefRangeStart = 80976, XrefRangeEnd = 80980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000AA2CC File Offset: 0x000A84CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80983, XrefRangeEnd = 80987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIOption.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000AA300 File Offset: 0x000A8500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80987, XrefRangeEnd = 80988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIOption.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000AA334 File Offset: 0x000A8534
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000AA370 File Offset: 0x000A8570
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000AA3AC File Offset: 0x000A85AC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_MoveRight_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000AA3E8 File Offset: 0x000A85E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80988, XrefRangeEnd = 81014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DetectInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000AA424 File Offset: 0x000A8624
		[CallerCount(0)]
		public unsafe virtual bool Navigate(Vector2 navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIOption.NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000AA478 File Offset: 0x000A8678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81019, RefRangeEnd = 81022, XrefRangeStart = 81014, XrefRangeEnd = 81019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIOption.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000086FC File Offset: 0x000068FC
		public UIOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00008705 File Offset: 0x00006905
		public unsafe UISelectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x000AA4E4 File Offset: 0x000A86E4
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00008724 File Offset: 0x00006924
		public unsafe TextMeshProUGUI nameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_nameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x000AA514 File Offset: 0x000A8714
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00008743 File Offset: 0x00006943
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000AA53C File Offset: 0x000A873C
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00008762 File Offset: 0x00006962
		public unsafe static float MoveThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIOption.NativeFieldInfoPtr_MoveThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIOption.NativeFieldInfoPtr_MoveThreshold, (void*)(&value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000AA558 File Offset: 0x000A8758
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00008770 File Offset: 0x00006970
		public unsafe bool wasNavPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_wasNavPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_wasNavPressedLastFrame)) = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000AA580 File Offset: 0x000A8780
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0000878B File Offset: 0x0000698B
		public unsafe float navTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_navTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.NativeFieldInfoPtr_navTimer)) = value;
			}
		}

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeFieldInfoPtr_nameText;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr_MoveThreshold;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr_wasNavPressedLastFrame;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr_navTimer;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_New_get_Single_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Protected_Virtual_New_Void_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Protected_Virtual_New_Void_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020008B5 RID: 2229
		public sealed class OptionInfo : ValueType
		{
			// Token: 0x0600D448 RID: 54344 RVA: 0x0034E224 File Offset: 0x0034C424
			// Note: this type is marked as 'beforefieldinit'.
			static OptionInfo()
			{
				Il2CppClassPointerStore<UIOption.OptionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIOption>.NativeClassPtr, "OptionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIOption.OptionInfo>.NativeClassPtr);
				UIOption.OptionInfo.NativeFieldInfoPtr_OptionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption.OptionInfo>.NativeClassPtr, "OptionName");
				UIOption.OptionInfo.NativeFieldInfoPtr_OptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIOption.OptionInfo>.NativeClassPtr, "OptionIndex");
			}

			// Token: 0x0600D449 RID: 54345 RVA: 0x00064623 File Offset: 0x00062823
			public OptionInfo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D44A RID: 54346 RVA: 0x0006462C File Offset: 0x0006282C
			public OptionInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIOption.OptionInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700409E RID: 16542
			// (get) Token: 0x0600D44B RID: 54347 RVA: 0x0034E278 File Offset: 0x0034C478
			// (set) Token: 0x0600D44C RID: 54348 RVA: 0x0006463E File Offset: 0x0006283E
			public unsafe string OptionName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.OptionInfo.NativeFieldInfoPtr_OptionName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.OptionInfo.NativeFieldInfoPtr_OptionName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0600D44D RID: 54349 RVA: 0x0034E2A0 File Offset: 0x0034C4A0
			// (set) Token: 0x0600D44E RID: 54350 RVA: 0x0006465D File Offset: 0x0006285D
			public unsafe int OptionIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.OptionInfo.NativeFieldInfoPtr_OptionIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIOption.OptionInfo.NativeFieldInfoPtr_OptionIndex)) = value;
				}
			}

			// Token: 0x0400908C RID: 37004
			private static readonly IntPtr NativeFieldInfoPtr_OptionName;

			// Token: 0x0400908D RID: 37005
			private static readonly IntPtr NativeFieldInfoPtr_OptionIndex;
		}
	}
}
