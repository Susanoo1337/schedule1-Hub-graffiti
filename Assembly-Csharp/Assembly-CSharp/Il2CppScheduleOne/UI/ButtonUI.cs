using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200071C RID: 1820
	public class ButtonUI : MonoBehaviour
	{
		// Token: 0x0600AFB1 RID: 44977 RVA: 0x002DFBA4 File Offset: 0x002DDDA4
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonUI()
		{
			Il2CppClassPointerStore<ButtonUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ButtonUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr);
			ButtonUI.NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, "_button");
			ButtonUI.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, "_id");
			ButtonUI.NativeFieldInfoPtr_OnSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, "OnSelect");
			ButtonUI.NativeMethodInfoPtr_get_Button_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, 100686399);
			ButtonUI.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, 100686400);
			ButtonUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, 100686401);
			ButtonUI.NativeMethodInfoPtr__Initialize_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr, 100686402);
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x002DFC60 File Offset: 0x002DDE60
		public unsafe Button Button
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonUI.NativeMethodInfoPtr_get_Button_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
			}
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x002DFCA0 File Offset: 0x002DDEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299274, RefRangeEnd = 299275, XrefRangeStart = 299265, XrefRangeEnd = 299274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonUI.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x002DFCE0 File Offset: 0x002DDEE0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x002DFD1C File Offset: 0x002DDF1C
		[CallerCount(0)]
		public unsafe void _Initialize_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonUI.NativeMethodInfoPtr__Initialize_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x00050A2D File Offset: 0x0004EC2D
		public ButtonUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034C4 RID: 13508
		// (get) Token: 0x0600AFB7 RID: 44983 RVA: 0x002DFD50 File Offset: 0x002DDF50
		// (set) Token: 0x0600AFB8 RID: 44984 RVA: 0x00050A36 File Offset: 0x0004EC36
		public unsafe Button _button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr__button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr__button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600AFB9 RID: 44985 RVA: 0x002DFD80 File Offset: 0x002DDF80
		// (set) Token: 0x0600AFBA RID: 44986 RVA: 0x00050A55 File Offset: 0x0004EC55
		public unsafe int _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr__id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr__id)) = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600AFBB RID: 44987 RVA: 0x002DFDA8 File Offset: 0x002DDFA8
		// (set) Token: 0x0600AFBC RID: 44988 RVA: 0x00050A70 File Offset: 0x0004EC70
		public unsafe Action<int> OnSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr_OnSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonUI.NativeFieldInfoPtr_OnSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007927 RID: 31015
		private static readonly IntPtr NativeFieldInfoPtr__button;

		// Token: 0x04007928 RID: 31016
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x04007929 RID: 31017
		private static readonly IntPtr NativeFieldInfoPtr_OnSelect;

		// Token: 0x0400792A RID: 31018
		private static readonly IntPtr NativeMethodInfoPtr_get_Button_Public_get_Button_0;

		// Token: 0x0400792B RID: 31019
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x0400792C RID: 31020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400792D RID: 31021
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__5_0_Private_Void_0;
	}
}
