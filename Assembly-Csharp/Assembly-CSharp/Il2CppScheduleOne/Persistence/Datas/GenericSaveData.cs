using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020A RID: 522
	[Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06002E0A RID: 11786 RVA: 0x00114A88 File Offset: 0x00112C88
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveData()
		{
			Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr);
			GenericSaveData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "GUID");
			GenericSaveData.NativeFieldInfoPtr_boolValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "boolValues");
			GenericSaveData.NativeFieldInfoPtr_floatValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "floatValues");
			GenericSaveData.NativeFieldInfoPtr_intValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "intValues");
			GenericSaveData.NativeFieldInfoPtr_stringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "stringValues");
			GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669338);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669339);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669340);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669341);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669342);
			GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669343);
			GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669344);
			GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669345);
			GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100669346);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00114BD0 File Offset: 0x00112DD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134633, RefRangeEnd = 134635, XrefRangeStart = 134600, XrefRangeEnd = 134633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveData(string guid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00114C1C File Offset: 0x00112E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134646, RefRangeEnd = 134648, XrefRangeStart = 134635, XrefRangeEnd = 134646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00114C6C File Offset: 0x00112E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134648, XrefRangeEnd = 134656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00114CBC File Offset: 0x00112EBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134667, RefRangeEnd = 134669, XrefRangeStart = 134656, XrefRangeEnd = 134667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00114D0C File Offset: 0x00112F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134669, XrefRangeEnd = 134681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00114D60 File Offset: 0x00112F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134695, RefRangeEnd = 134697, XrefRangeStart = 134681, XrefRangeEnd = 134695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key, bool defaultValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00114DBC File Offset: 0x00112FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134697, XrefRangeEnd = 134711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string key, float defaultValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00114E18 File Offset: 0x00113018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134725, RefRangeEnd = 134727, XrefRangeStart = 134711, XrefRangeEnd = 134725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string key, int defaultValue = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00114E74 File Offset: 0x00113074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134727, XrefRangeEnd = 134741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string key, string defaultValue = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000174FE File Offset: 0x000156FE
		public GenericSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x00114ED0 File Offset: 0x001130D0
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x00017507 File Offset: 0x00015707
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x00114EF8 File Offset: 0x001130F8
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x00017526 File Offset: 0x00015726
		public unsafe List<GenericSaveData.BoolValue> boolValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.BoolValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00114F28 File Offset: 0x00113128
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x00017545 File Offset: 0x00015745
		public unsafe List<GenericSaveData.FloatValue> floatValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.FloatValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00114F58 File Offset: 0x00113158
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x00017564 File Offset: 0x00015764
		public unsafe List<GenericSaveData.IntValue> intValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.IntValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00114F88 File Offset: 0x00113188
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00017583 File Offset: 0x00015783
		public unsafe List<GenericSaveData.StringValue> stringValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.StringValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_boolValues;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeFieldInfoPtr_floatValues;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeFieldInfoPtr_intValues;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeFieldInfoPtr_stringValues;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Single_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Int32_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_0;

		// Token: 0x020009EC RID: 2540
		[Serializable]
		public class BoolValue : Object
		{
			// Token: 0x0600DCE1 RID: 56545 RVA: 0x003691C0 File Offset: 0x003673C0
			// Note: this type is marked as 'beforefieldinit'.
			static BoolValue()
			{
				Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "BoolValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr);
				GenericSaveData.BoolValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "key");
				GenericSaveData.BoolValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "value");
				GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, 100669347);
			}

			// Token: 0x0600DCE2 RID: 56546 RVA: 0x00369228 File Offset: 0x00367428
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCE3 RID: 56547 RVA: 0x00067F21 File Offset: 0x00066121
			public BoolValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434C RID: 17228
			// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x00369264 File Offset: 0x00367464
			// (set) Token: 0x0600DCE5 RID: 56549 RVA: 0x00067F2A File Offset: 0x0006612A
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700434D RID: 17229
			// (get) Token: 0x0600DCE6 RID: 56550 RVA: 0x0036928C File Offset: 0x0036748C
			// (set) Token: 0x0600DCE7 RID: 56551 RVA: 0x00067F49 File Offset: 0x00066149
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400969E RID: 38558
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400969F RID: 38559
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040096A0 RID: 38560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009ED RID: 2541
		[Serializable]
		public class FloatValue : Object
		{
			// Token: 0x0600DCE8 RID: 56552 RVA: 0x003692B4 File Offset: 0x003674B4
			// Note: this type is marked as 'beforefieldinit'.
			static FloatValue()
			{
				Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "FloatValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr);
				GenericSaveData.FloatValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "key");
				GenericSaveData.FloatValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "value");
				GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, 100669348);
			}

			// Token: 0x0600DCE9 RID: 56553 RVA: 0x0036931C File Offset: 0x0036751C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCEA RID: 56554 RVA: 0x00067F64 File Offset: 0x00066164
			public FloatValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434E RID: 17230
			// (get) Token: 0x0600DCEB RID: 56555 RVA: 0x00369358 File Offset: 0x00367558
			// (set) Token: 0x0600DCEC RID: 56556 RVA: 0x00067F6D File Offset: 0x0006616D
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700434F RID: 17231
			// (get) Token: 0x0600DCED RID: 56557 RVA: 0x00369380 File Offset: 0x00367580
			// (set) Token: 0x0600DCEE RID: 56558 RVA: 0x00067F8C File Offset: 0x0006618C
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040096A1 RID: 38561
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096A2 RID: 38562
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040096A3 RID: 38563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009EE RID: 2542
		[Serializable]
		public class IntValue : Object
		{
			// Token: 0x0600DCEF RID: 56559 RVA: 0x003693A8 File Offset: 0x003675A8
			// Note: this type is marked as 'beforefieldinit'.
			static IntValue()
			{
				Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "IntValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr);
				GenericSaveData.IntValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "key");
				GenericSaveData.IntValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "value");
				GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, 100669349);
			}

			// Token: 0x0600DCF0 RID: 56560 RVA: 0x00369410 File Offset: 0x00367610
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF1 RID: 56561 RVA: 0x00067FA7 File Offset: 0x000661A7
			public IntValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004350 RID: 17232
			// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x0036944C File Offset: 0x0036764C
			// (set) Token: 0x0600DCF3 RID: 56563 RVA: 0x00067FB0 File Offset: 0x000661B0
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00369474 File Offset: 0x00367674
			// (set) Token: 0x0600DCF5 RID: 56565 RVA: 0x00067FCF File Offset: 0x000661CF
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x040096A4 RID: 38564
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096A5 RID: 38565
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040096A6 RID: 38566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009EF RID: 2543
		[Serializable]
		public class StringValue : Object
		{
			// Token: 0x0600DCF6 RID: 56566 RVA: 0x0036949C File Offset: 0x0036769C
			// Note: this type is marked as 'beforefieldinit'.
			static StringValue()
			{
				Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "StringValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr);
				GenericSaveData.StringValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "key");
				GenericSaveData.StringValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "value");
				GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, 100669350);
			}

			// Token: 0x0600DCF7 RID: 56567 RVA: 0x00369504 File Offset: 0x00367704
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCF8 RID: 56568 RVA: 0x00067FEA File Offset: 0x000661EA
			public StringValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600DCF9 RID: 56569 RVA: 0x00369540 File Offset: 0x00367740
			// (set) Token: 0x0600DCFA RID: 56570 RVA: 0x00067FF3 File Offset: 0x000661F3
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600DCFB RID: 56571 RVA: 0x00369568 File Offset: 0x00367768
			// (set) Token: 0x0600DCFC RID: 56572 RVA: 0x00068012 File Offset: 0x00066212
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096A7 RID: 38567
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096A8 RID: 38568
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040096A9 RID: 38569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F0 RID: 2544
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600DCFD RID: 56573 RVA: 0x00369590 File Offset: 0x00367790
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100669351);
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100669352);
			}

			// Token: 0x0600DCFE RID: 56574 RVA: 0x003695F8 File Offset: 0x003677F8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCFF RID: 56575 RVA: 0x00369634 File Offset: 0x00367834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134598, XrefRangeEnd = 134600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBool_b__0(GenericSaveData.BoolValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD00 RID: 56576 RVA: 0x00068031 File Offset: 0x00066231
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600DD01 RID: 56577 RVA: 0x00369684 File Offset: 0x00367884
			// (set) Token: 0x0600DD02 RID: 56578 RVA: 0x0006803A File Offset: 0x0006623A
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096AA RID: 38570
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096AB RID: 38571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096AC RID: 38572
			private static readonly IntPtr NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0;
		}

		// Token: 0x020009F1 RID: 2545
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600DD03 RID: 56579 RVA: 0x003696AC File Offset: 0x003678AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100669353);
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100669354);
			}

			// Token: 0x0600DD04 RID: 56580 RVA: 0x00369714 File Offset: 0x00367914
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD05 RID: 56581 RVA: 0x00369750 File Offset: 0x00367950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFloat_b__0(GenericSaveData.FloatValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD06 RID: 56582 RVA: 0x00068059 File Offset: 0x00066259
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600DD07 RID: 56583 RVA: 0x003697A0 File Offset: 0x003679A0
			// (set) Token: 0x0600DD08 RID: 56584 RVA: 0x00068062 File Offset: 0x00066262
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096AD RID: 38573
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096AE RID: 38574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096AF RID: 38575
			private static readonly IntPtr NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0;
		}

		// Token: 0x020009F2 RID: 2546
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600DD09 RID: 56585 RVA: 0x003697C8 File Offset: 0x003679C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100669355);
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100669356);
			}

			// Token: 0x0600DD0A RID: 56586 RVA: 0x00369830 File Offset: 0x00367A30
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD0B RID: 56587 RVA: 0x0036986C File Offset: 0x00367A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetInt_b__0(GenericSaveData.IntValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD0C RID: 56588 RVA: 0x00068081 File Offset: 0x00066281
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x003698BC File Offset: 0x00367ABC
			// (set) Token: 0x0600DD0E RID: 56590 RVA: 0x0006808A File Offset: 0x0006628A
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096B0 RID: 38576
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096B1 RID: 38577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096B2 RID: 38578
			private static readonly IntPtr NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0;
		}

		// Token: 0x020009F3 RID: 2547
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600DD0F RID: 56591 RVA: 0x003698E4 File Offset: 0x00367AE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100669357);
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100669358);
			}

			// Token: 0x0600DD10 RID: 56592 RVA: 0x0036994C File Offset: 0x00367B4C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD11 RID: 56593 RVA: 0x00369988 File Offset: 0x00367B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetString_b__0(GenericSaveData.StringValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD12 RID: 56594 RVA: 0x000680A9 File Offset: 0x000662A9
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600DD13 RID: 56595 RVA: 0x003699D8 File Offset: 0x00367BD8
			// (set) Token: 0x0600DD14 RID: 56596 RVA: 0x000680B2 File Offset: 0x000662B2
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040096B3 RID: 38579
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040096B4 RID: 38580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096B5 RID: 38581
			private static readonly IntPtr NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0;
		}
	}
}
