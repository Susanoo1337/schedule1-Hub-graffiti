using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GamepadInput;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200070F RID: 1807
	public class AmountSelector : MonoBehaviour
	{
		// Token: 0x0600AE54 RID: 44628 RVA: 0x002DBBEC File Offset: 0x002D9DEC
		// Note: this type is marked as 'beforefieldinit'.
		static AmountSelector()
		{
			Il2CppClassPointerStore<AmountSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "AmountSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr);
			AmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "<SelectedAmount>k__BackingField");
			AmountSelector.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "MinValue");
			AmountSelector.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "MaxValue");
			AmountSelector.NativeFieldInfoPtr__inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "_inputField");
			AmountSelector.NativeFieldInfoPtr__tmpInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "_tmpInputField");
			AmountSelector.NativeFieldInfoPtr__ramp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "_ramp");
			AmountSelector.NativeFieldInfoPtr_OnAmountChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, "OnAmountChanged");
			AmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686255);
			AmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686256);
			AmountSelector.NativeMethodInfoPtr_add_OnAmountChanged_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686257);
			AmountSelector.NativeMethodInfoPtr_remove_OnAmountChanged_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686258);
			AmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686259);
			AmountSelector.NativeMethodInfoPtr_InputFieldSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686260);
			AmountSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686261);
			AmountSelector.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686262);
			AmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr, 100686263);
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600AE55 RID: 44629 RVA: 0x002DBD5C File Offset: 0x002D9F5C
		// (set) Token: 0x0600AE56 RID: 44630 RVA: 0x002DBD98 File Offset: 0x002D9F98
		public unsafe float SelectedAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x002DBDD8 File Offset: 0x002D9FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297908, RefRangeEnd = 297909, XrefRangeStart = 297903, XrefRangeEnd = 297908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAmountChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_add_OnAmountChanged_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x002DBE1C File Offset: 0x002DA01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297909, XrefRangeEnd = 297914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAmountChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_remove_OnAmountChanged_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x002DBE60 File Offset: 0x002DA060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297914, XrefRangeEnd = 297948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x002DBE94 File Offset: 0x002DA094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297948, XrefRangeEnd = 297950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputFieldSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_InputFieldSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x002DBED8 File Offset: 0x002DA0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297950, XrefRangeEnd = 297951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x002DBF18 File Offset: 0x002DA118
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 297968, RefRangeEnd = 297977, XrefRangeStart = 297951, XrefRangeEnd = 297968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x002DBF58 File Offset: 0x002DA158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297977, XrefRangeEnd = 297978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmountSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmountSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x0004FD57 File Offset: 0x0004DF57
		public AmountSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600AE5F RID: 44639 RVA: 0x002DBF94 File Offset: 0x002DA194
		// (set) Token: 0x0600AE60 RID: 44640 RVA: 0x0004FD60 File Offset: 0x0004DF60
		public unsafe float _SelectedAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600AE61 RID: 44641 RVA: 0x002DBFBC File Offset: 0x002DA1BC
		// (set) Token: 0x0600AE62 RID: 44642 RVA: 0x0004FD7B File Offset: 0x0004DF7B
		public unsafe float MinValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_MinValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_MinValue)) = value;
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600AE63 RID: 44643 RVA: 0x002DBFE4 File Offset: 0x002DA1E4
		// (set) Token: 0x0600AE64 RID: 44644 RVA: 0x0004FD96 File Offset: 0x0004DF96
		public unsafe float MaxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_MaxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_MaxValue)) = value;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600AE65 RID: 44645 RVA: 0x002DC00C File Offset: 0x002DA20C
		// (set) Token: 0x0600AE66 RID: 44646 RVA: 0x0004FDB1 File Offset: 0x0004DFB1
		public unsafe InputField _inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600AE67 RID: 44647 RVA: 0x002DC03C File Offset: 0x002DA23C
		// (set) Token: 0x0600AE68 RID: 44648 RVA: 0x0004FDD0 File Offset: 0x0004DFD0
		public unsafe TMP_InputField _tmpInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__tmpInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__tmpInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x002DC06C File Offset: 0x002DA26C
		// (set) Token: 0x0600AE6A RID: 44650 RVA: 0x0004FDEF File Offset: 0x0004DFEF
		public unsafe InputValueRamp _ramp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__ramp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr__ramp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600AE6B RID: 44651 RVA: 0x002DC09C File Offset: 0x002DA29C
		// (set) Token: 0x0600AE6C RID: 44652 RVA: 0x0004FE0E File Offset: 0x0004E00E
		public unsafe Action<float> OnAmountChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_OnAmountChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmountSelector.NativeFieldInfoPtr_OnAmountChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007850 RID: 30800
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAmount_k__BackingField;

		// Token: 0x04007851 RID: 30801
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04007852 RID: 30802
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04007853 RID: 30803
		private static readonly IntPtr NativeFieldInfoPtr__inputField;

		// Token: 0x04007854 RID: 30804
		private static readonly IntPtr NativeFieldInfoPtr__tmpInputField;

		// Token: 0x04007855 RID: 30805
		private static readonly IntPtr NativeFieldInfoPtr__ramp;

		// Token: 0x04007856 RID: 30806
		private static readonly IntPtr NativeFieldInfoPtr_OnAmountChanged;

		// Token: 0x04007857 RID: 30807
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAmount_Public_get_Single_0;

		// Token: 0x04007858 RID: 30808
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Single_0;

		// Token: 0x04007859 RID: 30809
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAmountChanged_Public_add_Void_Action_1_Single_0;

		// Token: 0x0400785A RID: 30810
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAmountChanged_Public_rem_Void_Action_1_Single_0;

		// Token: 0x0400785B RID: 30811
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400785C RID: 30812
		private static readonly IntPtr NativeMethodInfoPtr_InputFieldSubmitted_Private_Void_String_0;

		// Token: 0x0400785D RID: 30813
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x0400785E RID: 30814
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Public_Void_Single_0;

		// Token: 0x0400785F RID: 30815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
