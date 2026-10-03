using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F9 RID: 249
	public class Variable<T> : BaseVariable
	{
		// Token: 0x0600179E RID: 6046 RVA: 0x000C91F4 File Offset: 0x000C73F4
		// Note: this type is marked as 'beforefieldinit'.
		static Variable()
		{
			Il2CppClassPointerStore<Variable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Variable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr);
			Variable<T>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "Value");
			Variable<T>.NativeFieldInfoPtr_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, "OnValueChanged");
			Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666526);
			Variable<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666527);
			Variable<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666528);
			Variable<T>.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666529);
			Variable<T>.NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr, 100666530);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000C92EC File Offset: 0x000C74EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97304, RefRangeEnd = 97306, XrefRangeStart = 97290, XrefRangeEnd = 97304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Variable<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variable<T>.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x000C93D4 File Offset: 0x000C75D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97306, XrefRangeEnd = 97307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000C9420 File Offset: 0x000C7620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97307, XrefRangeEnd = 97341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object value, bool replicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000C947C File Offset: 0x000C767C
		[CallerCount(0)]
		public unsafe virtual bool TryDeserialize(string valueString, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(valueString);
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
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000C9524 File Offset: 0x000C7724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97341, XrefRangeEnd = 97349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReplicateValue(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Variable<T>.NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0000CFA9 File Offset: 0x0000B1A9
		public Variable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000C9574 File Offset: 0x000C7774
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x000C959C File Offset: 0x000C779C
		public unsafe T Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_Value);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_Value);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x000C9644 File Offset: 0x000C7844
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000CFB2 File Offset: 0x0000B1B2
		public unsafe UnityEvent<T> OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Variable<T>.NativeFieldInfoPtr_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_OnValueChanged;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_T_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Boolean_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_New_Boolean_String_byref_T_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateValue_Public_Virtual_Void_NetworkConnection_0;
	}
}
