using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E2 RID: 1250
	public class FloatStack : Object
	{
		// Token: 0x060071CD RID: 29133 RVA: 0x00201530 File Offset: 0x001FF730
		// Note: this type is marked as 'beforefieldinit'.
		static FloatStack()
		{
			Il2CppClassPointerStore<FloatStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FloatStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack>.NativeClassPtr);
			FloatStack.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "<Value>k__BackingField");
			FloatStack.NativeFieldInfoPtr_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "OnValueChanged");
			FloatStack.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "_defaultValue");
			FloatStack.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "_stack");
			FloatStack.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678004);
			FloatStack.NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678005);
			FloatStack.NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678006);
			FloatStack.NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678007);
			FloatStack.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678008);
			FloatStack.NativeMethodInfoPtr_SetDefaultValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678009);
			FloatStack.NativeMethodInfoPtr_Add_Public_Void_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678010);
			FloatStack.NativeMethodInfoPtr_Remove_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678011);
			FloatStack.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_String_byref_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678012);
			FloatStack.NativeMethodInfoPtr_Recalculate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, 100678013);
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x060071CE RID: 29134 RVA: 0x00201678 File Offset: 0x001FF878
		// (set) Token: 0x060071CF RID: 29135 RVA: 0x002016B4 File Offset: 0x001FF8B4
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29030, RefRangeEnd = 29033, XrefRangeStart = 29030, XrefRangeEnd = 29033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x002016F4 File Offset: 0x001FF8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225821, RefRangeEnd = 225823, XrefRangeStart = 225816, XrefRangeEnd = 225821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnValueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00201738 File Offset: 0x001FF938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225823, XrefRangeEnd = 225828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnValueChanged(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x0020177C File Offset: 0x001FF97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225837, RefRangeEnd = 225840, XrefRangeStart = 225828, XrefRangeEnd = 225837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatStack(float defaultValue) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x002017C4 File Offset: 0x001FF9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225841, RefRangeEnd = 225842, XrefRangeStart = 225840, XrefRangeEnd = 225841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultValue(float defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_SetDefaultValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00201804 File Offset: 0x001FFA04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 225864, RefRangeEnd = 225874, XrefRangeStart = 225842, XrefRangeEnd = 225864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(FloatStack.StackEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_Add_Public_Void_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00201848 File Offset: 0x001FFA48
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 225890, RefRangeEnd = 225900, XrefRangeStart = 225874, XrefRangeEnd = 225890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_Remove_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x0020188C File Offset: 0x001FFA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225900, XrefRangeEnd = 225915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetEntry(string label, out FloatStack.StackEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_TryGetEntry_Public_Boolean_String_byref_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new FloatStack.StackEntry(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x002018FC File Offset: 0x001FFAFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 225955, RefRangeEnd = 225959, XrefRangeStart = 225915, XrefRangeEnd = 225955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.NativeMethodInfoPtr_Recalculate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x0003624A File Offset: 0x0003444A
		public FloatStack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x00201930 File Offset: 0x001FFB30
		// (set) Token: 0x060071DA RID: 29146 RVA: 0x00036253 File Offset: 0x00034453
		public unsafe float _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x00201958 File Offset: 0x001FFB58
		// (set) Token: 0x060071DC RID: 29148 RVA: 0x0003626E File Offset: 0x0003446E
		public unsafe Action<float> OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x00201988 File Offset: 0x001FFB88
		// (set) Token: 0x060071DE RID: 29150 RVA: 0x0003628D File Offset: 0x0003448D
		public unsafe float _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__defaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__defaultValue)) = value;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x002019B0 File Offset: 0x001FFBB0
		// (set) Token: 0x060071E0 RID: 29152 RVA: 0x000362A8 File Offset: 0x000344A8
		public unsafe List<FloatStack.StackEntry> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloatStack.StackEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DC2 RID: 19906
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04004DC3 RID: 19907
		private static readonly IntPtr NativeFieldInfoPtr_OnValueChanged;

		// Token: 0x04004DC4 RID: 19908
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x04004DC5 RID: 19909
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x04004DC6 RID: 19910
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04004DC7 RID: 19911
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0;

		// Token: 0x04004DC8 RID: 19912
		private static readonly IntPtr NativeMethodInfoPtr_add_OnValueChanged_Public_add_Void_Action_1_Single_0;

		// Token: 0x04004DC9 RID: 19913
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnValueChanged_Public_rem_Void_Action_1_Single_0;

		// Token: 0x04004DCA RID: 19914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04004DCB RID: 19915
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultValue_Public_Void_Single_0;

		// Token: 0x04004DCC RID: 19916
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_StackEntry_0;

		// Token: 0x04004DCD RID: 19917
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_0;

		// Token: 0x04004DCE RID: 19918
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEntry_Public_Boolean_String_byref_StackEntry_0;

		// Token: 0x04004DCF RID: 19919
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Private_Void_0;

		// Token: 0x02000B95 RID: 2965
		[OriginalName("Assembly-CSharp.dll", "", "EStackMode")]
		public enum EStackMode
		{
			// Token: 0x04009E8F RID: 40591
			Additive,
			// Token: 0x04009E90 RID: 40592
			Override,
			// Token: 0x04009E91 RID: 40593
			Multiplicative
		}

		// Token: 0x02000B96 RID: 2966
		public class StackEntry : Object
		{
			// Token: 0x0600E9D8 RID: 59864 RVA: 0x0038D820 File Offset: 0x0038BA20
			// Note: this type is marked as 'beforefieldinit'.
			static StackEntry()
			{
				Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "StackEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr);
				FloatStack.StackEntry.NativeFieldInfoPtr__Label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, "<Label>k__BackingField");
				FloatStack.StackEntry.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, "<Value>k__BackingField");
				FloatStack.StackEntry.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, "<Mode>k__BackingField");
				FloatStack.StackEntry.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, "<Order>k__BackingField");
				FloatStack.StackEntry.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678014);
				FloatStack.StackEntry.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678015);
				FloatStack.StackEntry.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678016);
				FloatStack.StackEntry.NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678017);
				FloatStack.StackEntry.NativeMethodInfoPtr_get_Mode_Public_get_EStackMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678018);
				FloatStack.StackEntry.NativeMethodInfoPtr_set_Mode_Private_set_Void_EStackMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678019);
				FloatStack.StackEntry.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678020);
				FloatStack.StackEntry.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678021);
				FloatStack.StackEntry.NativeMethodInfoPtr__ctor_Public_Void_String_Single_EStackMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr, 100678022);
			}

			// Token: 0x170046F5 RID: 18165
			// (get) Token: 0x0600E9D9 RID: 59865 RVA: 0x0038D950 File Offset: 0x0038BB50
			// (set) Token: 0x0600E9DA RID: 59866 RVA: 0x0038D988 File Offset: 0x0038BB88
			public unsafe string Label
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_set_Label_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170046F6 RID: 18166
			// (get) Token: 0x0600E9DB RID: 59867 RVA: 0x0038D9CC File Offset: 0x0038BBCC
			// (set) Token: 0x0600E9DC RID: 59868 RVA: 0x0038DA08 File Offset: 0x0038BC08
			public unsafe float Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 149236, RefRangeEnd = 149240, XrefRangeStart = 149236, XrefRangeEnd = 149240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170046F7 RID: 18167
			// (get) Token: 0x0600E9DD RID: 59869 RVA: 0x0038DA48 File Offset: 0x0038BC48
			// (set) Token: 0x0600E9DE RID: 59870 RVA: 0x0038DA84 File Offset: 0x0038BC84
			public unsafe FloatStack.EStackMode Mode
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_get_Mode_Public_get_EStackMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_set_Mode_Private_set_Void_EStackMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170046F8 RID: 18168
			// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x0038DAC4 File Offset: 0x0038BCC4
			// (set) Token: 0x0600E9E0 RID: 59872 RVA: 0x0038DB00 File Offset: 0x0038BD00
			public unsafe int Order
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600E9E1 RID: 59873 RVA: 0x0038DB40 File Offset: 0x0038BD40
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 225805, RefRangeEnd = 225815, XrefRangeStart = 225803, XrefRangeEnd = 225805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StackEntry(string label, float value, FloatStack.EStackMode mode, int order) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack.StackEntry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.StackEntry.NativeMethodInfoPtr__ctor_Public_Void_String_Single_EStackMode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9E2 RID: 59874 RVA: 0x0006E55B File Offset: 0x0006C75B
			public StackEntry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046F1 RID: 18161
			// (get) Token: 0x0600E9E3 RID: 59875 RVA: 0x0038DBB8 File Offset: 0x0038BDB8
			// (set) Token: 0x0600E9E4 RID: 59876 RVA: 0x0006E564 File Offset: 0x0006C764
			public unsafe string _Label_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Label_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Label_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170046F2 RID: 18162
			// (get) Token: 0x0600E9E5 RID: 59877 RVA: 0x0038DBE0 File Offset: 0x0038BDE0
			// (set) Token: 0x0600E9E6 RID: 59878 RVA: 0x0006E583 File Offset: 0x0006C783
			public unsafe float _Value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Value_k__BackingField)) = value;
				}
			}

			// Token: 0x170046F3 RID: 18163
			// (get) Token: 0x0600E9E7 RID: 59879 RVA: 0x0038DC08 File Offset: 0x0038BE08
			// (set) Token: 0x0600E9E8 RID: 59880 RVA: 0x0006E59E File Offset: 0x0006C79E
			public unsafe FloatStack.EStackMode _Mode_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Mode_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
				}
			}

			// Token: 0x170046F4 RID: 18164
			// (get) Token: 0x0600E9E9 RID: 59881 RVA: 0x0038DC30 File Offset: 0x0038BE30
			// (set) Token: 0x0600E9EA RID: 59882 RVA: 0x0006E5B9 File Offset: 0x0006C7B9
			public unsafe int _Order_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Order_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.StackEntry.NativeFieldInfoPtr__Order_k__BackingField)) = value;
				}
			}

			// Token: 0x04009E92 RID: 40594
			private static readonly IntPtr NativeFieldInfoPtr__Label_k__BackingField;

			// Token: 0x04009E93 RID: 40595
			private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

			// Token: 0x04009E94 RID: 40596
			private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

			// Token: 0x04009E95 RID: 40597
			private static readonly IntPtr NativeFieldInfoPtr__Order_k__BackingField;

			// Token: 0x04009E96 RID: 40598
			private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

			// Token: 0x04009E97 RID: 40599
			private static readonly IntPtr NativeMethodInfoPtr_set_Label_Private_set_Void_String_0;

			// Token: 0x04009E98 RID: 40600
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

			// Token: 0x04009E99 RID: 40601
			private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Single_0;

			// Token: 0x04009E9A RID: 40602
			private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EStackMode_0;

			// Token: 0x04009E9B RID: 40603
			private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Private_set_Void_EStackMode_0;

			// Token: 0x04009E9C RID: 40604
			private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

			// Token: 0x04009E9D RID: 40605
			private static readonly IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

			// Token: 0x04009E9E RID: 40606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_EStackMode_Int32_0;
		}

		// Token: 0x02000B97 RID: 2967
		[ObfuscatedName("ScheduleOne.Tools.FloatStack+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E9EB RID: 59883 RVA: 0x0038DC58 File Offset: 0x0038BE58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr);
				FloatStack.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr, "<>9");
				FloatStack.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr, "<>9__16_0");
				FloatStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr, 100678024);
				FloatStack.__c.NativeMethodInfoPtr__Recalculate_b__16_0_Internal_Int32_StackEntry_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr, 100678025);
			}

			// Token: 0x0600E9EC RID: 59884 RVA: 0x0038DCD4 File Offset: 0x0038BED4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9ED RID: 59885 RVA: 0x0038DD10 File Offset: 0x0038BF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225815, XrefRangeEnd = 225816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Recalculate_b__16_0(FloatStack.StackEntry a, FloatStack.StackEntry b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c.NativeMethodInfoPtr__Recalculate_b__16_0_Internal_Int32_StackEntry_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9EE RID: 59886 RVA: 0x0006E5D4 File Offset: 0x0006C7D4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046F9 RID: 18169
			// (get) Token: 0x0600E9EF RID: 59887 RVA: 0x0038DD70 File Offset: 0x0038BF70
			// (set) Token: 0x0600E9F0 RID: 59888 RVA: 0x0006E5DD File Offset: 0x0006C7DD
			public unsafe static FloatStack.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatStack.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatStack.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatStack.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046FA RID: 18170
			// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x0038DD98 File Offset: 0x0038BF98
			// (set) Token: 0x0600E9F2 RID: 59890 RVA: 0x0006E5EF File Offset: 0x0006C7EF
			public unsafe static Comparison<FloatStack.StackEntry> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatStack.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatStack.StackEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatStack.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E9F RID: 40607
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009EA0 RID: 40608
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009EA1 RID: 40609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EA2 RID: 40610
			private static readonly IntPtr NativeMethodInfoPtr__Recalculate_b__16_0_Internal_Int32_StackEntry_StackEntry_0;
		}

		// Token: 0x02000B98 RID: 2968
		[ObfuscatedName("ScheduleOne.Tools.FloatStack+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600E9F3 RID: 59891 RVA: 0x0038DDC0 File Offset: 0x0038BFC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr);
				FloatStack.__c__DisplayClass13_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr, "entry");
				FloatStack.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr, 100678026);
				FloatStack.__c__DisplayClass13_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr, 100678027);
			}

			// Token: 0x0600E9F4 RID: 59892 RVA: 0x0038DE28 File Offset: 0x0038C028
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9F5 RID: 59893 RVA: 0x0038DE64 File Offset: 0x0038C064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Add_b__0(FloatStack.StackEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass13_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9F6 RID: 59894 RVA: 0x0006E601 File Offset: 0x0006C801
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046FB RID: 18171
			// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x0038DEB4 File Offset: 0x0038C0B4
			// (set) Token: 0x0600E9F8 RID: 59896 RVA: 0x0006E60A File Offset: 0x0006C80A
			public unsafe FloatStack.StackEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass13_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatStack.StackEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass13_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EA3 RID: 40611
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009EA4 RID: 40612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EA5 RID: 40613
			private static readonly IntPtr NativeMethodInfoPtr__Add_b__0_Internal_Boolean_StackEntry_0;
		}

		// Token: 0x02000B99 RID: 2969
		[ObfuscatedName("ScheduleOne.Tools.FloatStack+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600E9F9 RID: 59897 RVA: 0x0038DEE4 File Offset: 0x0038C0E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr);
				FloatStack.__c__DisplayClass14_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr, "label");
				FloatStack.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr, 100678028);
				FloatStack.__c__DisplayClass14_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr, 100678029);
			}

			// Token: 0x0600E9FA RID: 59898 RVA: 0x0038DF4C File Offset: 0x0038C14C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9FB RID: 59899 RVA: 0x0038DF88 File Offset: 0x0038C188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Remove_b__0(FloatStack.StackEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass14_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9FC RID: 59900 RVA: 0x0006E629 File Offset: 0x0006C829
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046FC RID: 18172
			// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x0038DFD8 File Offset: 0x0038C1D8
			// (set) Token: 0x0600E9FE RID: 59902 RVA: 0x0006E632 File Offset: 0x0006C832
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass14_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass14_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009EA6 RID: 40614
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009EA7 RID: 40615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EA8 RID: 40616
			private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_StackEntry_0;
		}

		// Token: 0x02000B9A RID: 2970
		[ObfuscatedName("ScheduleOne.Tools.FloatStack+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600E9FF RID: 59903 RVA: 0x0038E000 File Offset: 0x0038C200
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatStack>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr);
				FloatStack.__c__DisplayClass15_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr, "label");
				FloatStack.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr, 100678030);
				FloatStack.__c__DisplayClass15_0.NativeMethodInfoPtr__TryGetEntry_b__0_Internal_Boolean_StackEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr, 100678031);
			}

			// Token: 0x0600EA00 RID: 59904 RVA: 0x0038E068 File Offset: 0x0038C268
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatStack.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA01 RID: 59905 RVA: 0x0038E0A4 File Offset: 0x0038C2A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetEntry_b__0(FloatStack.StackEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatStack.__c__DisplayClass15_0.NativeMethodInfoPtr__TryGetEntry_b__0_Internal_Boolean_StackEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA02 RID: 59906 RVA: 0x0006E651 File Offset: 0x0006C851
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046FD RID: 18173
			// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x0038E0F4 File Offset: 0x0038C2F4
			// (set) Token: 0x0600EA04 RID: 59908 RVA: 0x0006E65A File Offset: 0x0006C85A
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass15_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatStack.__c__DisplayClass15_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009EA9 RID: 40617
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009EAA RID: 40618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EAB RID: 40619
			private static readonly IntPtr NativeMethodInfoPtr__TryGetEntry_b__0_Internal_Boolean_StackEntry_0;
		}
	}
}
