using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003FF RID: 1023
	public class PlayerSingleton<T> : MonoBehaviour where T : PlayerSingleton<T>
	{
		// Token: 0x06005AAB RID: 23211 RVA: 0x001B4110 File Offset: 0x001B2310
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSingleton()
		{
			Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr);
			PlayerSingleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, "instance");
			PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675145);
			PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675146);
			PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675147);
			PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675148);
			PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675149);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675150);
			PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675151);
			PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr, 100675152);
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x001B4230 File Offset: 0x001B2430
		public unsafe static bool InstanceExists
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 195924, RefRangeEnd = 195987, XrefRangeStart = 195918, XrefRangeEnd = 195924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x001B4260 File Offset: 0x001B2460
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x001B4290 File Offset: 0x001B2490
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(260)]
			[CachedScanResults(RefRangeStart = 195186, RefRangeEnd = 195446, XrefRangeStart = 195186, XrefRangeEnd = 195446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x001B4314 File Offset: 0x001B2514
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 195987, RefRangeEnd = 196018, XrefRangeStart = 195987, XrefRangeEnd = 195987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x001B4350 File Offset: 0x001B2550
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x001B438C File Offset: 0x001B258C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196055, RefRangeEnd = 196061, XrefRangeStart = 196018, XrefRangeEnd = 196055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x001B43D8 File Offset: 0x001B25D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 196067, RefRangeEnd = 196072, XrefRangeStart = 196061, XrefRangeEnd = 196067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x001B4414 File Offset: 0x001B2614
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x0002AF6A File Offset: 0x0002916A
		public PlayerSingleton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x001B4450 File Offset: 0x001B2650
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x001B4474 File Offset: 0x001B2674
		public unsafe static T instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSingleton<T>.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_instance = PlayerSingleton<T>.NativeFieldInfoPtr_instance;
				T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&ptr2));
			}
		}

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
