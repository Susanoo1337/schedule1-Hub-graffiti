using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E1 RID: 1249
	[Serializable]
	public class FloatSmoother : Object
	{
		// Token: 0x060071B3 RID: 29107 RVA: 0x00200F8C File Offset: 0x001FF18C
		// Note: this type is marked as 'beforefieldinit'.
		static FloatSmoother()
		{
			Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "FloatSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr);
			FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			FloatSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "DefaultValue");
			FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "SmoothingSpeed");
			FloatSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "overrides");
			FloatSmoother.NativeFieldInfoPtr_activeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "activeOverride");
			FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677983);
			FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677984);
			FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677985);
			FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677986);
			FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677987);
			FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677988);
			FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677989);
			FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677990);
			FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677991);
			FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677992);
			FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677993);
			FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, 100677994);
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060071B4 RID: 29108 RVA: 0x00201124 File Offset: 0x001FF324
		// (set) Token: 0x060071B5 RID: 29109 RVA: 0x00201160 File Offset: 0x001FF360
		public unsafe float CurrentValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060071B6 RID: 29110 RVA: 0x002011A0 File Offset: 0x001FF3A0
		// (set) Token: 0x060071B7 RID: 29111 RVA: 0x002011DC File Offset: 0x001FF3DC
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26895, RefRangeEnd = 26896, XrefRangeStart = 26895, XrefRangeEnd = 26896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x0020121C File Offset: 0x001FF41C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 225577, RefRangeEnd = 225590, XrefRangeStart = 225574, XrefRangeEnd = 225577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x00201250 File Offset: 0x001FF450
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 225593, RefRangeEnd = 225603, XrefRangeStart = 225590, XrefRangeEnd = 225593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(float value, bool apply = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref apply;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x0020129C File Offset: 0x001FF49C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 26895, RefRangeEnd = 26896, XrefRangeStart = 26895, XrefRangeEnd = 26896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x002012DC File Offset: 0x001FF4DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 29110, RefRangeEnd = 29119, XrefRangeStart = 29110, XrefRangeEnd = 29119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSmoothingSpeed(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x0020131C File Offset: 0x001FF51C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 225671, RefRangeEnd = 225705, XrefRangeStart = 225603, XrefRangeEnd = 225671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(float value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x0020137C File Offset: 0x001FF57C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 225760, RefRangeEnd = 225792, XrefRangeStart = 225705, XrefRangeEnd = 225760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x002013C0 File Offset: 0x001FF5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225792, XrefRangeEnd = 225794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x002013F4 File Offset: 0x001FF5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225802, RefRangeEnd = 225803, XrefRangeStart = 225794, XrefRangeEnd = 225802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x00036197 File Offset: 0x00034397
		public FloatSmoother(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x00201430 File Offset: 0x001FF630
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x000361A0 File Offset: 0x000343A0
		public unsafe float _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00201458 File Offset: 0x001FF658
		// (set) Token: 0x060071C4 RID: 29124 RVA: 0x000361BB File Offset: 0x000343BB
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x00201480 File Offset: 0x001FF680
		// (set) Token: 0x060071C6 RID: 29126 RVA: 0x000361D6 File Offset: 0x000343D6
		public unsafe float DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x002014A8 File Offset: 0x001FF6A8
		// (set) Token: 0x060071C8 RID: 29128 RVA: 0x000361F1 File Offset: 0x000343F1
		public unsafe float SmoothingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x002014D0 File Offset: 0x001FF6D0
		// (set) Token: 0x060071CA RID: 29130 RVA: 0x0003620C File Offset: 0x0003440C
		public unsafe List<FloatSmoother.Override> overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FloatSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x00201500 File Offset: 0x001FF700
		// (set) Token: 0x060071CC RID: 29132 RVA: 0x0003622B File Offset: 0x0003442B
		public unsafe FloatSmoother.Override activeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_activeOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother.Override>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.NativeFieldInfoPtr_activeOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DB0 RID: 19888
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x04004DB1 RID: 19889
		private static readonly IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x04004DB2 RID: 19890
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x04004DB3 RID: 19891
		private static readonly IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x04004DB4 RID: 19892
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x04004DB5 RID: 19893
		private static readonly IntPtr NativeFieldInfoPtr_activeOverride;

		// Token: 0x04004DB6 RID: 19894
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Single_0;

		// Token: 0x04004DB7 RID: 19895
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Single_0;

		// Token: 0x04004DB8 RID: 19896
		private static readonly IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x04004DB9 RID: 19897
		private static readonly IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x04004DBA RID: 19898
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04004DBB RID: 19899
		private static readonly IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Single_Boolean_0;

		// Token: 0x04004DBC RID: 19900
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04004DBD RID: 19901
		private static readonly IntPtr NativeMethodInfoPtr_SetSmoothingSpeed_Public_Void_Single_0;

		// Token: 0x04004DBE RID: 19902
		private static readonly IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Single_Int32_String_0;

		// Token: 0x04004DBF RID: 19903
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x04004DC0 RID: 19904
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04004DC1 RID: 19905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B91 RID: 2961
		public class Override : Object
		{
			// Token: 0x0600E9B8 RID: 59832 RVA: 0x0038D2A0 File Offset: 0x0038B4A0
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr);
				FloatSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Value");
				FloatSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Priority");
				FloatSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, "Label");
				FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr, 100677995);
			}

			// Token: 0x0600E9B9 RID: 59833 RVA: 0x0038D31C File Offset: 0x0038B51C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.Override>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9BA RID: 59834 RVA: 0x0006E46E File Offset: 0x0006C66E
			public Override(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E9 RID: 18153
			// (get) Token: 0x0600E9BB RID: 59835 RVA: 0x0038D358 File Offset: 0x0038B558
			// (set) Token: 0x0600E9BC RID: 59836 RVA: 0x0006E477 File Offset: 0x0006C677
			public unsafe float Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170046EA RID: 18154
			// (get) Token: 0x0600E9BD RID: 59837 RVA: 0x0038D380 File Offset: 0x0038B580
			// (set) Token: 0x0600E9BE RID: 59838 RVA: 0x0006E492 File Offset: 0x0006C692
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x170046EB RID: 18155
			// (get) Token: 0x0600E9BF RID: 59839 RVA: 0x0038D3A8 File Offset: 0x0038B5A8
			// (set) Token: 0x0600E9C0 RID: 59840 RVA: 0x0006E4AD File Offset: 0x0006C6AD
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009E7E RID: 40574
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04009E7F RID: 40575
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04009E80 RID: 40576
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009E81 RID: 40577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B92 RID: 2962
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E9C1 RID: 59841 RVA: 0x0038D3D0 File Offset: 0x0038B5D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr);
				FloatSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9");
				FloatSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__17_1");
				FloatSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, "<>9__18_1");
				FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100677997);
				FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100677998);
				FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr, 100677999);
			}

			// Token: 0x0600E9C2 RID: 59842 RVA: 0x0038D474 File Offset: 0x0038B674
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9C3 RID: 59843 RVA: 0x0038D4B0 File Offset: 0x0038B6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225572, XrefRangeEnd = 225574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__17_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9C4 RID: 59844 RVA: 0x0038D510 File Offset: 0x0038B710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__18_1(FloatSmoother.Override x, FloatSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9C5 RID: 59845 RVA: 0x0006E4CC File Offset: 0x0006C6CC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046EC RID: 18156
			// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x0038D570 File Offset: 0x0038B770
			// (set) Token: 0x0600E9C7 RID: 59847 RVA: 0x0006E4D5 File Offset: 0x0006C6D5
			public unsafe static FloatSmoother.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046ED RID: 18157
			// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x0038D598 File Offset: 0x0038B798
			// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x0006E4E7 File Offset: 0x0006C6E7
			public unsafe static Comparison<FloatSmoother.Override> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046EE RID: 18158
			// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x0038D5C0 File Offset: 0x0038B7C0
			// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x0006E4F9 File Offset: 0x0006C6F9
			public unsafe static Comparison<FloatSmoother.Override> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FloatSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FloatSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E82 RID: 40578
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009E83 RID: 40579
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x04009E84 RID: 40580
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04009E85 RID: 40581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E86 RID: 40582
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__17_1_Internal_Int32_Override_Override_0;

			// Token: 0x04009E87 RID: 40583
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__18_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000B93 RID: 2963
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600E9CC RID: 59852 RVA: 0x0038D5E8 File Offset: 0x0038B7E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678000);
				FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678001);
			}

			// Token: 0x0600E9CD RID: 59853 RVA: 0x0038D650 File Offset: 0x0038B850
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9CE RID: 59854 RVA: 0x0038D68C File Offset: 0x0038B88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9CF RID: 59855 RVA: 0x0006E50B File Offset: 0x0006C70B
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046EF RID: 18159
			// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x0038D6DC File Offset: 0x0038B8DC
			// (set) Token: 0x0600E9D1 RID: 59857 RVA: 0x0006E514 File Offset: 0x0006C714
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009E88 RID: 40584
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009E89 RID: 40585
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E8A RID: 40586
			private static readonly IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000B94 RID: 2964
		[ObfuscatedName("ScheduleOne.Tools.FloatSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Object
		{
			// Token: 0x0600E9D2 RID: 59858 RVA: 0x0038D704 File Offset: 0x0038B904
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678002);
				FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678003);
			}

			// Token: 0x0600E9D3 RID: 59859 RVA: 0x0038D76C File Offset: 0x0038B96C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9D4 RID: 59860 RVA: 0x0038D7A8 File Offset: 0x0038B9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(FloatSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9D5 RID: 59861 RVA: 0x0006E533 File Offset: 0x0006C733
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046F0 RID: 18160
			// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x0038D7F8 File Offset: 0x0038B9F8
			// (set) Token: 0x0600E9D7 RID: 59863 RVA: 0x0006E53C File Offset: 0x0006C73C
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009E8B RID: 40587
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009E8C RID: 40588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E8D RID: 40589
			private static readonly IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
