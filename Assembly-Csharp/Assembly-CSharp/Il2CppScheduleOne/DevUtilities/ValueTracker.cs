using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000409 RID: 1033
	public class ValueTracker : Object
	{
		// Token: 0x06005B2E RID: 23342 RVA: 0x001B5CA0 File Offset: 0x001B3EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTracker()
		{
			Il2CppClassPointerStore<ValueTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ValueTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr);
			ValueTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "historyDuration");
			ValueTracker.NativeFieldInfoPtr_valueHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "valueHistory");
			ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675205);
			ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675206);
			ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675207);
			ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675208);
			ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675209);
			ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675210);
			ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100675211);
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x001B5D84 File Offset: 0x001B3F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196785, RefRangeEnd = 196786, XrefRangeStart = 196759, XrefRangeEnd = 196785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTracker(float HistoryDuration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref HistoryDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x001B5DCC File Offset: 0x001B3FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196786, XrefRangeEnd = 196804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x001B5E00 File Offset: 0x001B4000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196804, XrefRangeEnd = 196813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x001B5E34 File Offset: 0x001B4034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196821, RefRangeEnd = 196822, XrefRangeStart = 196813, XrefRangeEnd = 196821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x001B5E74 File Offset: 0x001B4074
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196827, RefRangeEnd = 196829, XrefRangeStart = 196822, XrefRangeEnd = 196827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecordedHistoryLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x001B5EB0 File Offset: 0x001B40B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196850, RefRangeEnd = 196852, XrefRangeStart = 196829, XrefRangeEnd = 196850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowestValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x001B5EEC File Offset: 0x001B40EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196852, XrefRangeEnd = 196867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x0002B2B6 File Offset: 0x000294B6
		public ValueTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x001B5F28 File Offset: 0x001B4128
		// (set) Token: 0x06005B38 RID: 23352 RVA: 0x0002B2BF File Offset: 0x000294BF
		public unsafe float historyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x001B5F50 File Offset: 0x001B4150
		// (set) Token: 0x06005B3A RID: 23354 RVA: 0x0002B2DA File Offset: 0x000294DA
		public unsafe List<ValueTracker.Value> valueHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTracker.Value>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeFieldInfoPtr_valueHistory;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04003E86 RID: 16006
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003E87 RID: 16007
		private static readonly IntPtr NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0;

		// Token: 0x04003E88 RID: 16008
		private static readonly IntPtr NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0;

		// Token: 0x04003E89 RID: 16009
		private static readonly IntPtr NativeMethodInfoPtr_GetLowestValue_Public_Single_0;

		// Token: 0x04003E8A RID: 16010
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageValue_Public_Single_0;

		// Token: 0x02000AED RID: 2797
		public class Value : Object
		{
			// Token: 0x0600E4FE RID: 58622 RVA: 0x0037FD4C File Offset: 0x0037DF4C
			// Note: this type is marked as 'beforefieldinit'.
			static Value()
			{
				Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "Value");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr);
				ValueTracker.Value.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "val");
				ValueTracker.Value.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "time");
				ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, 100675212);
			}

			// Token: 0x0600E4FF RID: 58623 RVA: 0x0037FDB4 File Offset: 0x0037DFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196758, XrefRangeEnd = 196759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Value(float val, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref val;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E500 RID: 58624 RVA: 0x0006BF40 File Offset: 0x0006A140
			public Value(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004599 RID: 17817
			// (get) Token: 0x0600E501 RID: 58625 RVA: 0x0037FE0C File Offset: 0x0037E00C
			// (set) Token: 0x0600E502 RID: 58626 RVA: 0x0006BF49 File Offset: 0x0006A149
			public unsafe float val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x1700459A RID: 17818
			// (get) Token: 0x0600E503 RID: 58627 RVA: 0x0037FE34 File Offset: 0x0037E034
			// (set) Token: 0x0600E504 RID: 58628 RVA: 0x0006BF64 File Offset: 0x0006A164
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04009B75 RID: 39797
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04009B76 RID: 39798
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04009B77 RID: 39799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
		}

		// Token: 0x02000AEE RID: 2798
		[ObfuscatedName("ScheduleOne.DevUtilities.ValueTracker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E505 RID: 58629 RVA: 0x0037FE5C File Offset: 0x0037E05C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr);
				ValueTracker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9");
				ValueTracker.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9__8_0");
				ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675214);
				ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100675215);
			}

			// Token: 0x0600E506 RID: 58630 RVA: 0x0037FED8 File Offset: 0x0037E0D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E507 RID: 58631 RVA: 0x0037FF14 File Offset: 0x0037E114
			[CallerCount(0)]
			public unsafe float _GetLowestValue_b__8_0(ValueTracker.Value x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E508 RID: 58632 RVA: 0x0006BF7F File Offset: 0x0006A17F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459B RID: 17819
			// (get) Token: 0x0600E509 RID: 58633 RVA: 0x0037FF64 File Offset: 0x0037E164
			// (set) Token: 0x0600E50A RID: 58634 RVA: 0x0006BF88 File Offset: 0x0006A188
			public unsafe static ValueTracker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700459C RID: 17820
			// (get) Token: 0x0600E50B RID: 58635 RVA: 0x0037FF8C File Offset: 0x0037E18C
			// (set) Token: 0x0600E50C RID: 58636 RVA: 0x0006BF9A File Offset: 0x0006A19A
			public unsafe static Func<ValueTracker.Value, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTracker.Value, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B78 RID: 39800
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B79 RID: 39801
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009B7A RID: 39802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B7B RID: 39803
			private static readonly IntPtr NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0;
		}
	}
}
