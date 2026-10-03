using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	// Token: 0x02000280 RID: 640
	public static class Assert : Object
	{
		// Token: 0x06002BC7 RID: 11207 RVA: 0x000A9C98 File Offset: 0x000A7E98
		// Note: this type is marked as 'beforefieldinit'.
		static Assert()
		{
			Il2CppClassPointerStore<Assert>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "Assert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assert>.NativeClassPtr);
			Assert.NativeFieldInfoPtr_raiseExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assert>.NativeClassPtr, "raiseExceptions");
			Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667994);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667995);
			Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667996);
			Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667997);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667998);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100667999);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668000);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668001);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668002);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668003);
			Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668004);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668005);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668006);
			Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668007);
			Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assert>.NativeClassPtr, 100668008);
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000A9E08 File Offset: 0x000A8008
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1294596, RefRangeEnd = 1294606, XrefRangeStart = 1294583, XrefRangeEnd = 1294596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fail(string message, string userMessage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000A9E50 File Offset: 0x000A8050
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1294610, RefRangeEnd = 1294615, XrefRangeStart = 1294606, XrefRangeEnd = 1294610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000A9E84 File Offset: 0x000A8084
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294628, RefRangeEnd = 1294631, XrefRangeStart = 1294615, XrefRangeEnd = 1294628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsTrue(bool condition, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000A9EC8 File Offset: 0x000A80C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294644, RefRangeEnd = 1294645, XrefRangeStart = 1294631, XrefRangeEnd = 1294644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsFalse(bool condition, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref condition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000A9F0C File Offset: 0x000A810C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294655, RefRangeEnd = 1294656, XrefRangeStart = 1294645, XrefRangeEnd = 1294655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = expected;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref expected;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				if (!(t2 is string))
				{
					ref T ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref actual;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000A9FEC File Offset: 0x000A81EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294662, RefRangeEnd = 1294663, XrefRangeStart = 1294656, XrefRangeEnd = 1294662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = expected;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref expected;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				if (!(t2 is string))
				{
					ref T ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref actual;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000AA0DC File Offset: 0x000A82DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294681, RefRangeEnd = 1294683, XrefRangeStart = 1294663, XrefRangeEnd = 1294681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = expected;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref expected;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr7;
			if (!typeof(T).IsValueType)
			{
				T t2 = actual;
				if (!(t2 is string))
				{
					ref T ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref actual;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000AA1E0 File Offset: 0x000A83E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294683, XrefRangeEnd = 1294692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual(Object expected, Object actual, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000AA23C File Offset: 0x000A843C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294710, RefRangeEnd = 1294712, XrefRangeStart = 1294692, XrefRangeEnd = 1294710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull<T>(T value) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000AA2C0 File Offset: 0x000A84C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294712, XrefRangeEnd = 1294726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull<T>(T value, string message) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000AA354 File Offset: 0x000A8554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294726, XrefRangeEnd = 1294735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNull(Object value, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000AA39C File Offset: 0x000A859C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1294753, RefRangeEnd = 1294756, XrefRangeStart = 1294735, XrefRangeEnd = 1294753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull<T>(T value) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000AA420 File Offset: 0x000A8620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1294770, RefRangeEnd = 1294771, XrefRangeStart = 1294756, XrefRangeEnd = 1294770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull<T>(T value, string message) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294771, XrefRangeEnd = 1294780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IsNotNull(Object value, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000AA4FC File Offset: 0x000A86FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294786, RefRangeEnd = 1294788, XrefRangeStart = 1294780, XrefRangeEnd = 1294786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AreEqual(int expected, int actual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expected;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actual;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000132CF File Offset: 0x000114CF
		public Assert(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000AA53C File Offset: 0x000A873C
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x000132D8 File Offset: 0x000114D8
		public unsafe static bool raiseExceptions
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Assert.NativeFieldInfoPtr_raiseExceptions, (void*)(&value));
			}
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000132E6 File Offset: 0x000114E6
		public new static bool Equals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.Equals should not be used for Assertions");
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000132F3 File Offset: 0x000114F3
		public new static bool ReferenceEquals(Object obj1, Object obj2)
		{
			throw new InvalidOperationException("Assert.ReferenceEquals should not be used for Assertions");
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000AA558 File Offset: 0x000A8758
		public static void IsFalse(bool condition)
		{
			if (condition)
			{
				Assert.IsFalse(condition, null);
			}
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00013300 File Offset: 0x00011500
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x0001330D File Offset: 0x0001150D
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x0001331A File Offset: 0x0001151A
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00013327 File Offset: 0x00011527
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00013339 File Offset: 0x00011539
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00013346 File Offset: 0x00011546
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00013353 File Offset: 0x00011553
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00013360 File Offset: 0x00011560
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new UnityEngine.Assertions.Comparers.FloatComparer(tolerance));
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00013372 File Offset: 0x00011572
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x0001337E File Offset: 0x0001157E
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, EqualityComparer<T>.Default);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000AA574 File Offset: 0x000A8774
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()).IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
			if (flag)
			{
				Assert.AreNotEqual(expected.TryCast<Object>(), actual.TryCast<Object>(), message);
			}
			else
			{
				bool flag2 = comparer.Equals(actual, expected);
				if (flag2)
				{
					Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
				}
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000AA5E4 File Offset: 0x000A87E4
		public static void AreNotEqual(Object expected, Object actual, string message)
		{
			bool flag = actual == expected;
			if (flag)
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000AA60C File Offset: 0x000A880C
		public static void AreEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000AA630 File Offset: 0x000A8830
		public static void AreEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000AA654 File Offset: 0x000A8854
		public static void AreNotEqual(sbyte expected, sbyte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, null);
			}
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000AA674 File Offset: 0x000A8874
		public static void AreNotEqual(sbyte expected, sbyte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<sbyte>(expected, actual, message);
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000AA694 File Offset: 0x000A8894
		public static void AreEqual(byte expected, byte actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000AA6B8 File Offset: 0x000A88B8
		public static void AreEqual(byte expected, byte actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000AA6DC File Offset: 0x000A88DC
		public static void AreNotEqual(byte expected, byte actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, null);
			}
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000AA6FC File Offset: 0x000A88FC
		public static void AreNotEqual(byte expected, byte actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<byte>(expected, actual, message);
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000AA71C File Offset: 0x000A891C
		public static void AreEqual(char expected, char actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000AA740 File Offset: 0x000A8940
		public static void AreEqual(char expected, char actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000AA764 File Offset: 0x000A8964
		public static void AreNotEqual(char expected, char actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, null);
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000AA784 File Offset: 0x000A8984
		public static void AreNotEqual(char expected, char actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<char>(expected, actual, message);
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000AA7A4 File Offset: 0x000A89A4
		public static void AreEqual(short expected, short actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000AA7C8 File Offset: 0x000A89C8
		public static void AreEqual(short expected, short actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000AA7EC File Offset: 0x000A89EC
		public static void AreNotEqual(short expected, short actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, null);
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000AA80C File Offset: 0x000A8A0C
		public static void AreNotEqual(short expected, short actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<short>(expected, actual, message);
			}
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000AA82C File Offset: 0x000A8A2C
		public static void AreEqual(ushort expected, ushort actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000AA850 File Offset: 0x000A8A50
		public static void AreEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000AA874 File Offset: 0x000A8A74
		public static void AreNotEqual(ushort expected, ushort actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, null);
			}
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000AA894 File Offset: 0x000A8A94
		public static void AreNotEqual(ushort expected, ushort actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ushort>(expected, actual, message);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
		public static void AreEqual(int expected, int actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
		public static void AreNotEqual(int expected, int actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, null);
			}
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000AA8F8 File Offset: 0x000A8AF8
		public static void AreNotEqual(int expected, int actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<int>(expected, actual, message);
			}
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000AA918 File Offset: 0x000A8B18
		public static void AreEqual(uint expected, uint actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000AA93C File Offset: 0x000A8B3C
		public static void AreEqual(uint expected, uint actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000AA960 File Offset: 0x000A8B60
		public static void AreNotEqual(uint expected, uint actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, null);
			}
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000AA980 File Offset: 0x000A8B80
		public static void AreNotEqual(uint expected, uint actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<uint>(expected, actual, message);
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000AA9A0 File Offset: 0x000A8BA0
		public static void AreEqual(long expected, long actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000AA9C4 File Offset: 0x000A8BC4
		public static void AreEqual(long expected, long actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000AA9E8 File Offset: 0x000A8BE8
		public static void AreNotEqual(long expected, long actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, null);
			}
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000AAA08 File Offset: 0x000A8C08
		public static void AreNotEqual(long expected, long actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<long>(expected, actual, message);
			}
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000AAA28 File Offset: 0x000A8C28
		public static void AreEqual(ulong expected, ulong actual)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000AAA4C File Offset: 0x000A8C4C
		public static void AreEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected != actual;
			if (flag)
			{
				Assert.AreEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000AAA70 File Offset: 0x000A8C70
		public static void AreNotEqual(ulong expected, ulong actual)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, null);
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000AAA90 File Offset: 0x000A8C90
		public static void AreNotEqual(ulong expected, ulong actual, string message)
		{
			bool flag = expected == actual;
			if (flag)
			{
				Assert.AreNotEqual<ulong>(expected, actual, message);
			}
		}

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeFieldInfoPtr_raiseExceptions;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Private_Static_Void_String_String_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_IsTrue_Public_Static_Void_Boolean_String_0;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_IsFalse_Public_Static_Void_Boolean_String_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Object_Object_String_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Static_Void_Object_String_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_IsNotNull_Public_Static_Void_Object_String_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_AreEqual_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04002647 RID: 9799
		public const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

		// Token: 0x02000C21 RID: 3105
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_0<T>
		{
			// Token: 0x04002C25 RID: 11301
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C22 RID: 3106
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_0<T>
		{
			// Token: 0x04002C26 RID: 11302
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C23 RID: 3107
		private sealed class MethodInfoStoreGeneric_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0<T>
		{
			// Token: 0x04002C27 RID: 11303
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_AreEqual_Public_Static_Void_T_T_String_IEqualityComparer_1_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C24 RID: 3108
		private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002C28 RID: 11304
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C25 RID: 3109
		private sealed class MethodInfoStoreGeneric_IsNull_Public_Static_Void_T_String_0<T>
		{
			// Token: 0x04002C29 RID: 11305
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C26 RID: 3110
		private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_0<T>
		{
			// Token: 0x04002C2A RID: 11306
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000C27 RID: 3111
		private sealed class MethodInfoStoreGeneric_IsNotNull_Public_Static_Void_T_String_0<T>
		{
			// Token: 0x04002C2B RID: 11307
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Assert.NativeMethodInfoPtr_IsNotNull_Public_Static_Void_T_String_0, Il2CppClassPointerStore<Assert>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
