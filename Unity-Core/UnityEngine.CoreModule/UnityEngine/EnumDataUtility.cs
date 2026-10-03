using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000137 RID: 311
	public static class EnumDataUtility : Object
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x00067A50 File Offset: 0x00065C50
		// Note: this type is marked as 'beforefieldinit'.
		static EnumDataUtility()
		{
			Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "EnumDataUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr);
			EnumDataUtility.NativeFieldInfoPtr_s_EnumData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "s_EnumData");
			EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665826);
			EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665827);
			EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665828);
			EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665829);
			EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665830);
			EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100665832);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00067B0C File Offset: 0x00065D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256248, RefRangeEnd = 1256249, XrefRangeStart = 1256004, XrefRangeEnd = 1256248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumData GetCachedEnumData(Type enumType, EnumDataUtility.CachedType cachedType = EnumDataUtility.CachedType.IncludeObsoleteExceptErrors, Func<string, string> nicifyName = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cachedType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nicifyName);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new EnumData(pointer);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00067B68 File Offset: 0x00065D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256306, RefRangeEnd = 1256307, XrefRangeStart = 1256249, XrefRangeEnd = 1256306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(enumData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00067BB8 File Offset: 0x00065DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256307, XrefRangeEnd = 1256318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckObsoleteAddition(FieldInfo field, EnumDataUtility.CachedType cachedType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cachedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00067C08 File Offset: 0x00065E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256318, XrefRangeEnd = 1256328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnumTooltipFromEnumField(FieldInfo field)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00067C44 File Offset: 0x00065E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256347, RefRangeEnd = 1256348, XrefRangeStart = 1256328, XrefRangeEnd = 1256347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nicifyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00067C94 File Offset: 0x00065E94
		[CallerCount(0)]
		public unsafe static string Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0(ref EnumDataUtility.__c__DisplayClass8_0 A_0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000C083 File Offset: 0x0000A283
		public EnumDataUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00067CD8 File Offset: 0x00065ED8
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000C08C File Offset: 0x0000A28C
		public unsafe static Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData> s_EnumData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00067D00 File Offset: 0x00065F00
		public static int EnumFlagsToInt(EnumData enumData, Enum enumValue)
		{
			bool unsigned = enumData.unsigned;
			int result;
			if (unsigned)
			{
				bool flag = enumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
				if (flag)
				{
					result = (int)Convert.ToUInt32(enumValue);
				}
				else
				{
					bool flag2 = enumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
					if (flag2)
					{
						ushort num = Convert.ToUInt16(enumValue);
						result = ((num == ushort.MaxValue) ? -1 : ((int)num));
					}
					else
					{
						byte b = Convert.ToByte(enumValue);
						result = ((b == byte.MaxValue) ? -1 : ((int)b));
					}
				}
			}
			else
			{
				result = Convert.ToInt32(enumValue);
			}
			return result;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00067D94 File Offset: 0x00065F94
		public static Enum IntToEnumFlags(Type enumType, int value)
		{
			EnumData cachedEnumData = EnumDataUtility.GetCachedEnumData(enumType, EnumDataUtility.CachedType.IncludeObsoleteExceptErrors, null);
			bool unsigned = cachedEnumData.unsigned;
			Enum result;
			if (unsigned)
			{
				bool flag = cachedEnumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
				if (flag)
				{
					uint num = (uint)value;
					result = Enum.Parse(enumType, num.ToString()).TryCast<Enum>();
				}
				else
				{
					bool flag2 = cachedEnumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
					if (flag2)
					{
						result = Enum.Parse(enumType, ((ushort)value).ToString()).TryCast<Enum>();
					}
					else
					{
						result = Enum.Parse(enumType, ((byte)value).ToString()).TryCast<Enum>();
					}
				}
			}
			else
			{
				result = Enum.Parse(enumType, value.ToString()).TryCast<Enum>();
			}
			return result;
		}

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_s_EnumData;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0;

		// Token: 0x020008C1 RID: 2241
		[OriginalName("UnityEngine.CoreModule.dll", "", "CachedType")]
		public enum CachedType
		{
			// Token: 0x04002B12 RID: 11026
			ExcludeObsolete,
			// Token: 0x04002B13 RID: 11027
			IncludeObsoleteExceptErrors,
			// Token: 0x04002B14 RID: 11028
			IncludeAllObsolete
		}

		// Token: 0x020008C2 RID: 2242
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060039F7 RID: 14839 RVA: 0x000B1D88 File Offset: 0x000AFF88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr);
				EnumDataUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_5");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_1");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_2");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_3");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_4");
				EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665834);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665835);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665836);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665837);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665838);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100665839);
			}

			// Token: 0x060039F8 RID: 14840 RVA: 0x000B1EA4 File Offset: 0x000B00A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060039F9 RID: 14841 RVA: 0x000B1EE0 File Offset: 0x000B00E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_5(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060039FA RID: 14842 RVA: 0x000B1F30 File Offset: 0x000B0130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255950, XrefRangeEnd = 1255963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCachedEnumData_b__2_1(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060039FB RID: 14843 RVA: 0x000B1F78 File Offset: 0x000B0178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255963, XrefRangeEnd = 1255964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enum _GetCachedEnumData_b__2_2(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enum>(intPtr3) : null;
			}

			// Token: 0x060039FC RID: 14844 RVA: 0x000B1FC8 File Offset: 0x000B01C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255964, XrefRangeEnd = 1255968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_3(Enum v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060039FD RID: 14845 RVA: 0x000B2018 File Offset: 0x000B0218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255968, XrefRangeEnd = 1255972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_4(Enum v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060039FE RID: 14846 RVA: 0x00015DAB File Offset: 0x00013FAB
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x060039FF RID: 14847 RVA: 0x000B2068 File Offset: 0x000B0268
			// (set) Token: 0x06003A00 RID: 14848 RVA: 0x00015DB4 File Offset: 0x00013FB4
			public unsafe static EnumDataUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumDataUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06003A01 RID: 14849 RVA: 0x000B2090 File Offset: 0x000B0290
			// (set) Token: 0x06003A02 RID: 14850 RVA: 0x00015DC6 File Offset: 0x00013FC6
			public unsafe static Func<FieldInfo, int> __9__2_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06003A03 RID: 14851 RVA: 0x000B20B8 File Offset: 0x000B02B8
			// (set) Token: 0x06003A04 RID: 14852 RVA: 0x00015DD8 File Offset: 0x00013FD8
			public unsafe static Func<FieldInfo, string> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000B20E0 File Offset: 0x000B02E0
			// (set) Token: 0x06003A06 RID: 14854 RVA: 0x00015DEA File Offset: 0x00013FEA
			public unsafe static Func<FieldInfo, Enum> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, Enum>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x06003A07 RID: 14855 RVA: 0x000B2108 File Offset: 0x000B0308
			// (set) Token: 0x06003A08 RID: 14856 RVA: 0x00015DFC File Offset: 0x00013FFC
			public unsafe static Func<Enum, int> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Enum, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x06003A09 RID: 14857 RVA: 0x000B2130 File Offset: 0x000B0330
			// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00015E0E File Offset: 0x0001400E
			public unsafe static Func<Enum, int> __9__2_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Enum, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B15 RID: 11029
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B16 RID: 11030
			private static readonly IntPtr NativeFieldInfoPtr___9__2_5;

			// Token: 0x04002B17 RID: 11031
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04002B18 RID: 11032
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04002B19 RID: 11033
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x04002B1A RID: 11034
			private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

			// Token: 0x04002B1B RID: 11035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B1C RID: 11036
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0;

			// Token: 0x04002B1D RID: 11037
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0;

			// Token: 0x04002B1E RID: 11038
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0;

			// Token: 0x04002B1F RID: 11039
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0;

			// Token: 0x04002B20 RID: 11040
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0;
		}

		// Token: 0x020008C3 RID: 2243
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06003A0B RID: 14859 RVA: 0x000B2158 File Offset: 0x000B0358
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr);
				EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, "nicifyName");
				EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100665840);
				EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100665841);
			}

			// Token: 0x06003A0C RID: 14860 RVA: 0x000B21C0 File Offset: 0x000B03C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A0D RID: 14861 RVA: 0x000B21FC File Offset: 0x000B03FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255972, XrefRangeEnd = 1256004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCachedEnumData_b__0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003A0E RID: 14862 RVA: 0x00015E20 File Offset: 0x00014020
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06003A0F RID: 14863 RVA: 0x000B2244 File Offset: 0x000B0444
			// (set) Token: 0x06003A10 RID: 14864 RVA: 0x00015E29 File Offset: 0x00014029
			public unsafe Func<string, string> nicifyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B21 RID: 11041
			private static readonly IntPtr NativeFieldInfoPtr_nicifyName;

			// Token: 0x04002B22 RID: 11042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B23 RID: 11043
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0;
		}

		// Token: 0x020008C4 RID: 2244
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : ValueType
		{
			// Token: 0x06003A11 RID: 14865 RVA: 0x000B2274 File Offset: 0x000B0474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr);
				EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, "nicifyName");
				EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, "field");
			}

			// Token: 0x06003A12 RID: 14866 RVA: 0x00015E48 File Offset: 0x00014048
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003A13 RID: 14867 RVA: 0x00015E51 File Offset: 0x00014051
			public __c__DisplayClass8_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr))
			{
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06003A14 RID: 14868 RVA: 0x000B22C8 File Offset: 0x000B04C8
			// (set) Token: 0x06003A15 RID: 14869 RVA: 0x00015E63 File Offset: 0x00014063
			public unsafe Func<string, string> nicifyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06003A16 RID: 14870 RVA: 0x000B22F8 File Offset: 0x000B04F8
			// (set) Token: 0x06003A17 RID: 14871 RVA: 0x00015E82 File Offset: 0x00014082
			public unsafe FieldInfo field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B24 RID: 11044
			private static readonly IntPtr NativeFieldInfoPtr_nicifyName;

			// Token: 0x04002B25 RID: 11045
			private static readonly IntPtr NativeFieldInfoPtr_field;
		}

		// Token: 0x020008C5 RID: 2245
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020008C6 RID: 2246
		public sealed class <>c__DisplayClass2_0
		{
		}
	}
}
