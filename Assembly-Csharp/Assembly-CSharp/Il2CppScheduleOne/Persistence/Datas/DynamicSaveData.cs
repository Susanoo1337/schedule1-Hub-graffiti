using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000205 RID: 517
	[Serializable]
	public class DynamicSaveData : SaveData
	{
		// Token: 0x06002DDB RID: 11739 RVA: 0x00114064 File Offset: 0x00112264
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicSaveData()
		{
			Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DynamicSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr);
			DynamicSaveData.NativeFieldInfoPtr_BaseData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "BaseData");
			DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "AdditionalDatas");
			DynamicSaveData.NativeMethodInfoPtr__ctor_Public_Void_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669322);
			DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669323);
			DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669324);
			DynamicSaveData.NativeMethodInfoPtr_GetData_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669325);
			DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669326);
			DynamicSaveData.NativeMethodInfoPtr_GetData_Public_T_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669327);
			DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669328);
			DynamicSaveData.NativeMethodInfoPtr_ExtractBaseData_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669329);
			DynamicSaveData.NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, 100669330);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00114170 File Offset: 0x00112370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134388, RefRangeEnd = 134390, XrefRangeStart = 134373, XrefRangeEnd = 134388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicSaveData(SaveData baseData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr__ctor_Public_Void_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x001141BC File Offset: 0x001123BC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 134410, RefRangeEnd = 134431, XrefRangeStart = 134390, XrefRangeEnd = 134410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string name, string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00114210 File Offset: 0x00112410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134431, XrefRangeEnd = 134433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string name, SaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x00114264 File Offset: 0x00112464
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134445, RefRangeEnd = 134449, XrefRangeStart = 134433, XrefRangeEnd = 134445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetData(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_GetData_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x001142AC File Offset: 0x001124AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134454, RefRangeEnd = 134455, XrefRangeStart = 134449, XrefRangeEnd = 134454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetData(string name, out string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			data = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00114314 File Offset: 0x00112514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134455, XrefRangeEnd = 134469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string name, bool warn = true) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_GetData_Public_T_String_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0011436C File Offset: 0x0011256C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 134481, RefRangeEnd = 134500, XrefRangeStart = 134469, XrefRangeEnd = 134481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetData<T>(string name, out T data) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref data;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_TryGetData_Public_Boolean_String_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				data = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00114408 File Offset: 0x00112608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134500, XrefRangeEnd = 134510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ExtractBaseData<T>() where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_ExtractBaseData_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x00114444 File Offset: 0x00112644
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 134530, RefRangeEnd = 134574, XrefRangeStart = 134510, XrefRangeEnd = 134530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryExtractBaseData<T>(out T data) where T : SaveData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref data;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.MethodInfoStoreGeneric_TryExtractBaseData_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				data = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x00017390 File Offset: 0x00015590
		public DynamicSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x001144D0 File Offset: 0x001126D0
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x00017399 File Offset: 0x00015599
		public unsafe string BaseData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_BaseData);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_BaseData), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x001144F8 File Offset: 0x001126F8
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x000173B8 File Offset: 0x000155B8
		public unsafe List<DynamicSaveData.AdditionalData> AdditionalDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynamicSaveData.AdditionalData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.NativeFieldInfoPtr_AdditionalDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_BaseData;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalDatas;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SaveData_0;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_String_0;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_SaveData_0;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_String_String_0;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_String_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_T_String_Boolean_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_ExtractBaseData_Public_T_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0;

		// Token: 0x020009E7 RID: 2535
		[Serializable]
		public class AdditionalData : Object
		{
			// Token: 0x0600DCD6 RID: 56534 RVA: 0x00368F7C File Offset: 0x0036717C
			// Note: this type is marked as 'beforefieldinit'.
			static AdditionalData()
			{
				Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr, "AdditionalData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr);
				DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, "Name");
				DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, "Contents");
				DynamicSaveData.AdditionalData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr, 100669331);
			}

			// Token: 0x0600DCD7 RID: 56535 RVA: 0x00368FE4 File Offset: 0x003671E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdditionalData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicSaveData.AdditionalData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicSaveData.AdditionalData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCD8 RID: 56536 RVA: 0x00067EDA File Offset: 0x000660DA
			public AdditionalData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434A RID: 17226
			// (get) Token: 0x0600DCD9 RID: 56537 RVA: 0x00369020 File Offset: 0x00367220
			// (set) Token: 0x0600DCDA RID: 56538 RVA: 0x00067EE3 File Offset: 0x000660E3
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700434B RID: 17227
			// (get) Token: 0x0600DCDB RID: 56539 RVA: 0x00369048 File Offset: 0x00367248
			// (set) Token: 0x0600DCDC RID: 56540 RVA: 0x00067F02 File Offset: 0x00066102
			public unsafe string Contents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicSaveData.AdditionalData.NativeFieldInfoPtr_Contents), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009697 RID: 38551
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009698 RID: 38552
			private static readonly IntPtr NativeFieldInfoPtr_Contents;

			// Token: 0x04009699 RID: 38553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009E8 RID: 2536
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_Boolean_0<T>
		{
			// Token: 0x0400969A RID: 38554
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_GetData_Public_T_String_Boolean_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009E9 RID: 2537
		private sealed class MethodInfoStoreGeneric_TryGetData_Public_Boolean_String_byref_T_0<T>
		{
			// Token: 0x0400969B RID: 38555
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_TryGetData_Public_Boolean_String_byref_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009EA RID: 2538
		private sealed class MethodInfoStoreGeneric_ExtractBaseData_Public_T_0<T>
		{
			// Token: 0x0400969C RID: 38556
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_ExtractBaseData_Public_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020009EB RID: 2539
		private sealed class MethodInfoStoreGeneric_TryExtractBaseData_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x0400969D RID: 38557
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DynamicSaveData.NativeMethodInfoPtr_TryExtractBaseData_Public_Boolean_byref_T_0, Il2CppClassPointerStore<DynamicSaveData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
