using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200025E RID: 606
	public static class PlayableOutputExtensions : Object
	{
		// Token: 0x06002A5D RID: 10845 RVA: 0x000A4E7C File Offset: 0x000A307C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputExtensions()
		{
			Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667845);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667846);
			PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667847);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667848);
			PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667849);
			PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667850);
			PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667851);
			PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr, 100667852);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000A4F4C File Offset: 0x000A314C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293590, RefRangeEnd = 1293591, XrefRangeStart = 1293581, XrefRangeEnd = 1293590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetReferenceObject<U>(this U output, Object value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000A4FE0 File Offset: 0x000A31E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293600, RefRangeEnd = 1293601, XrefRangeStart = 1293591, XrefRangeEnd = 1293600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserData<U>(this U output, Object value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000A5074 File Offset: 0x000A3274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293608, RefRangeEnd = 1293611, XrefRangeStart = 1293601, XrefRangeEnd = 1293608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable GetSourcePlayable<U>(this U output) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000A5100 File Offset: 0x000A3300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293624, RefRangeEnd = 1293625, XrefRangeStart = 1293611, XrefRangeEnd = 1293624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSourcePlayable<U, V>(this U output, V value, int port) where U : new() where V : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			V ptr7;
			if (!typeof(V).IsValueType)
			{
				V v = value;
				if (!(v is string))
				{
					ref V ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000A51EC File Offset: 0x000A33EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293631, RefRangeEnd = 1293633, XrefRangeStart = 1293625, XrefRangeEnd = 1293631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSourceOutputPort<U>(this U output) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000A5278 File Offset: 0x000A3478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293639, RefRangeEnd = 1293642, XrefRangeStart = 1293633, XrefRangeEnd = 1293639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWeight<U>(this U output, float value) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000A5308 File Offset: 0x000A3508
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293655, RefRangeEnd = 1293658, XrefRangeStart = 1293642, XrefRangeEnd = 1293655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushNotification<U>(this U output, Playable origin, INotification notification, Object context = null) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000A53BC File Offset: 0x000A35BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293667, RefRangeEnd = 1293668, XrefRangeStart = 1293658, XrefRangeEnd = 1293667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNotificationReceiver<U>(this U output, INotificationReceiver receiver) where U : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			U ptr4;
			if (!typeof(U).IsValueType)
			{
				U u = output;
				if (!(u is string))
				{
					ref U ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(u as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(u as string);
				}
			}
			else
			{
				ptr4 = ref output;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputExtensions.MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00012CB0 File Offset: 0x00010EB0
		public PlayableOutputExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000A5450 File Offset: 0x000A3650
		public static bool IsOutputNull<U>(U output) where U : struct
		{
			return output.GetHandle().IsNull();
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000A5478 File Offset: 0x000A3678
		public static bool IsOutputValid<U>(U output) where U : struct
		{
			return output.GetHandle().IsValid();
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000A54A0 File Offset: 0x000A36A0
		public static Object GetReferenceObject<U>(U output) where U : struct
		{
			return output.GetHandle().GetReferenceObject();
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000A54C8 File Offset: 0x000A36C8
		public static Object GetUserData<U>(U output) where U : struct
		{
			return output.GetHandle().GetUserData();
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000A54F0 File Offset: 0x000A36F0
		public static void SetSourcePlayable<U, V>(U output, V value) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), output.GetSourceOutputPort<U>());
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000A5528 File Offset: 0x000A3728
		public static float GetWeight<U>(U output) where U : struct
		{
			return output.GetHandle().GetWeight();
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000A5550 File Offset: 0x000A3750
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers<U>(U output) where U : struct
		{
			return output.GetHandle().GetNotificationReceivers();
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000A5578 File Offset: 0x000A3778
		public static void RemoveNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().RemoveNotificationReceiver(receiver);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000A55A0 File Offset: 0x000A37A0
		public static int GetSourceInputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00012CB9 File Offset: 0x00010EB9
		public static void SetSourceInputPort<U>(U output, int value) where U : struct
		{
			output.SetSourcePlayable(output.GetSourcePlayable<U>(), value);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00012CCA File Offset: 0x00010ECA
		public static void SetSourceOutputPort<U>(U output, int value) where U : struct
		{
			output.SetSourcePlayable(output.GetSourcePlayable<U>(), value);
		}

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0;

		// Token: 0x02000BD7 RID: 3031
		private sealed class MethodInfoStoreGeneric_SetReferenceObject_Public_Static_Void_U_Object_0<U>
		{
			// Token: 0x04002C17 RID: 11287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetReferenceObject_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BD8 RID: 3032
		private sealed class MethodInfoStoreGeneric_SetUserData_Public_Static_Void_U_Object_0<U>
		{
			// Token: 0x04002C18 RID: 11288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetUserData_Public_Static_Void_U_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BD9 RID: 3033
		private sealed class MethodInfoStoreGeneric_GetSourcePlayable_Public_Static_Playable_U_0<U>
		{
			// Token: 0x04002C19 RID: 11289
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourcePlayable_Public_Static_Playable_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BDA RID: 3034
		private sealed class MethodInfoStoreGeneric_SetSourcePlayable_Public_Static_Void_U_V_Int32_0<U, V>
		{
			// Token: 0x04002C1A RID: 11290
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetSourcePlayable_Public_Static_Void_U_V_Int32_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BDB RID: 3035
		private sealed class MethodInfoStoreGeneric_GetSourceOutputPort_Public_Static_Int32_U_0<U>
		{
			// Token: 0x04002C1B RID: 11291
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_GetSourceOutputPort_Public_Static_Int32_U_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BDC RID: 3036
		private sealed class MethodInfoStoreGeneric_SetWeight_Public_Static_Void_U_Single_0<U>
		{
			// Token: 0x04002C1C RID: 11292
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_SetWeight_Public_Static_Void_U_Single_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BDD RID: 3037
		private sealed class MethodInfoStoreGeneric_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0<U>
		{
			// Token: 0x04002C1D RID: 11293
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_PushNotification_Public_Static_Void_U_Playable_INotification_Object_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BDE RID: 3038
		private sealed class MethodInfoStoreGeneric_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0<U>
		{
			// Token: 0x04002C1E RID: 11294
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputExtensions.NativeMethodInfoPtr_AddNotificationReceiver_Public_Static_Void_U_INotificationReceiver_0, Il2CppClassPointerStore<PlayableOutputExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}
	}
}
