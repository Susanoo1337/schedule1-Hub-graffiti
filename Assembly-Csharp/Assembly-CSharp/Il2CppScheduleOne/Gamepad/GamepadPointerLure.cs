using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E5 RID: 1765
	public class GamepadPointerLure : MonoBehaviour
	{
		// Token: 0x0600AA85 RID: 43653 RVA: 0x002D07D4 File Offset: 0x002CE9D4
		// Note: this type is marked as 'beforefieldinit'.
		static GamepadPointerLure()
		{
			Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "GamepadPointerLure");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr);
			GamepadPointerLure.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, "_data");
			GamepadPointerLure.NativeFieldInfoPtr__registerDefaultLureWhenEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, "_registerDefaultLureWhenEmpty");
			GamepadPointerLure.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, "_isActive");
			GamepadPointerLure.NativeFieldInfoPtr__Offset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, "<Offset>k__BackingField");
			GamepadPointerLure.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_GamepadPointerLureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685905);
			GamepadPointerLure.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685906);
			GamepadPointerLure.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685907);
			GamepadPointerLure.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685908);
			GamepadPointerLure.NativeMethodInfoPtr_get_Offset_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685909);
			GamepadPointerLure.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685910);
			GamepadPointerLure.NativeMethodInfoPtr_SetActive_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685911);
			GamepadPointerLure.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685912);
			GamepadPointerLure.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685913);
			GamepadPointerLure.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr, 100685914);
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600AA86 RID: 43654 RVA: 0x002D091C File Offset: 0x002CEB1C
		public unsafe virtual GamepadPointerLureData Data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_GamepadPointerLureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr3) : null;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600AA87 RID: 43655 RVA: 0x002D095C File Offset: 0x002CEB5C
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x002D0998 File Offset: 0x002CEB98
		public unsafe virtual bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x002D09D4 File Offset: 0x002CEBD4
		public unsafe virtual Vector3 Position
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 101087, RefRangeEnd = 101108, XrefRangeStart = 101087, XrefRangeEnd = 101108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x002D0A10 File Offset: 0x002CEC10
		public unsafe virtual Vector3 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_get_Offset_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AA8B RID: 43659 RVA: 0x002D0A4C File Offset: 0x002CEC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294581, XrefRangeEnd = 294591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x002D0A80 File Offset: 0x002CEC80
		[CallerCount(0)]
		public unsafe virtual void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_SetActive_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x002D0AC0 File Offset: 0x002CECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294591, XrefRangeEnd = 294605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x002D0AF4 File Offset: 0x002CECF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294605, XrefRangeEnd = 294617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x002D0B28 File Offset: 0x002CED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamepadPointerLure() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamepadPointerLure>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamepadPointerLure.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA90 RID: 43664 RVA: 0x0004DBC4 File Offset: 0x0004BDC4
		public GamepadPointerLure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x002D0B64 File Offset: 0x002CED64
		// (set) Token: 0x0600AA92 RID: 43666 RVA: 0x0004DBCD File Offset: 0x0004BDCD
		public unsafe GamepadPointerLureData _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x002D0B94 File Offset: 0x002CED94
		// (set) Token: 0x0600AA94 RID: 43668 RVA: 0x0004DBEC File Offset: 0x0004BDEC
		public unsafe bool _registerDefaultLureWhenEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__registerDefaultLureWhenEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__registerDefaultLureWhenEmpty)) = value;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x002D0BBC File Offset: 0x002CEDBC
		// (set) Token: 0x0600AA96 RID: 43670 RVA: 0x0004DC07 File Offset: 0x0004BE07
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600AA97 RID: 43671 RVA: 0x002D0BE4 File Offset: 0x002CEDE4
		// (set) Token: 0x0600AA98 RID: 43672 RVA: 0x0004DC22 File Offset: 0x0004BE22
		public unsafe Vector3 _Offset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__Offset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamepadPointerLure.NativeFieldInfoPtr__Offset_k__BackingField)) = value;
			}
		}

		// Token: 0x040075DA RID: 30170
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040075DB RID: 30171
		private static readonly IntPtr NativeFieldInfoPtr__registerDefaultLureWhenEmpty;

		// Token: 0x040075DC RID: 30172
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040075DD RID: 30173
		private static readonly IntPtr NativeFieldInfoPtr__Offset_k__BackingField;

		// Token: 0x040075DE RID: 30174
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_GamepadPointerLureData_0;

		// Token: 0x040075DF RID: 30175
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040075E0 RID: 30176
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040075E1 RID: 30177
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040075E2 RID: 30178
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x040075E3 RID: 30179
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040075E4 RID: 30180
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Virtual_Final_New_Void_Boolean_0;

		// Token: 0x040075E5 RID: 30181
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040075E6 RID: 30182
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040075E7 RID: 30183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
