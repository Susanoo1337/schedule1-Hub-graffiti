using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000431 RID: 1073
	public class CasinoGamePlayerData : Object
	{
		// Token: 0x06005F02 RID: 24322 RVA: 0x001C36FC File Offset: 0x001C18FC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerData()
		{
			Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr);
			CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Parent>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Player>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr_bools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "bools");
			CasinoGamePlayerData.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "floats");
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675745);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675746);
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675747);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675748);
			CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675749);
			CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675750);
			CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100675751);
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x001C3808 File Offset: 0x001C1A08
		// (set) Token: 0x06005F04 RID: 24324 RVA: 0x001C3848 File Offset: 0x001C1A48
		public unsafe CasinoGamePlayers Parent
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x001C388C File Offset: 0x001C1A8C
		// (set) Token: 0x06005F06 RID: 24326 RVA: 0x001C38CC File Offset: 0x001C1ACC
		public unsafe Player Player
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x001C3910 File Offset: 0x001C1B10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202499, RefRangeEnd = 202504, XrefRangeStart = 202472, XrefRangeEnd = 202499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData(CasinoGamePlayers parent, Player player) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x001C3970 File Offset: 0x001C1B70
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 202536, RefRangeEnd = 202544, XrefRangeStart = 202504, XrefRangeEnd = 202536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_GetData_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x001C39BC File Offset: 0x001C1BBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202591, RefRangeEnd = 202596, XrefRangeStart = 202544, XrefRangeEnd = 202591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(string key, T value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0002CEFA File Offset: 0x0002B0FA
		public CasinoGamePlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x001C3A6C File Offset: 0x001C1C6C
		// (set) Token: 0x06005F0C RID: 24332 RVA: 0x0002CF03 File Offset: 0x0002B103
		public unsafe CasinoGamePlayers _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x001C3A9C File Offset: 0x001C1C9C
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x0002CF22 File Offset: 0x0002B122
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x001C3ACC File Offset: 0x001C1CCC
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x0002CF41 File Offset: 0x0002B141
		public unsafe Dictionary<string, bool> bools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001C3AFC File Offset: 0x001C1CFC
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x0002CF60 File Offset: 0x0002B160
		public unsafe Dictionary<string, float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeFieldInfoPtr_bools;

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0;

		// Token: 0x04004168 RID: 16744
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0;

		// Token: 0x04004169 RID: 16745
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x0400416A RID: 16746
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x0400416B RID: 16747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0;

		// Token: 0x0400416C RID: 16748
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_T_String_0;

		// Token: 0x0400416D RID: 16749
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0;

		// Token: 0x02000B1F RID: 2847
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_0<T>
		{
			// Token: 0x04009C28 RID: 39976
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B20 RID: 2848
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>
		{
			// Token: 0x04009C29 RID: 39977
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
