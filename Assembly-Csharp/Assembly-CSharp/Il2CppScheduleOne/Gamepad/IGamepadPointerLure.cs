using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E6 RID: 1766
	public class IGamepadPointerLure : Il2CppObjectBase
	{
		// Token: 0x0600AA99 RID: 43673 RVA: 0x002D0C0C File Offset: 0x002CEE0C
		// Note: this type is marked as 'beforefieldinit'.
		static IGamepadPointerLure()
		{
			Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "IGamepadPointerLure");
			IGamepadPointerLure.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_GamepadPointerLureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685915);
			IGamepadPointerLure.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685916);
			IGamepadPointerLure.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685917);
			IGamepadPointerLure.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685918);
			IGamepadPointerLure.NativeMethodInfoPtr_get_Offset_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685919);
			IGamepadPointerLure.NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerLure>.NativeClassPtr, 100685920);
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600AA9A RID: 43674 RVA: 0x002D0CAC File Offset: 0x002CEEAC
		public unsafe virtual GamepadPointerLureData Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_GamepadPointerLureData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GamepadPointerLureData>(intPtr3) : null;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600AA9B RID: 43675 RVA: 0x002D0CF8 File Offset: 0x002CEEF8
		public unsafe virtual bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600AA9C RID: 43676 RVA: 0x002D0D40 File Offset: 0x002CEF40
		public unsafe virtual bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x002D0D88 File Offset: 0x002CEF88
		public unsafe virtual Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x002D0DD0 File Offset: 0x002CEFD0
		public unsafe virtual Vector3 Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_get_Offset_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x002D0E18 File Offset: 0x002CF018
		[CallerCount(0)]
		public unsafe virtual void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerLure.NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x0004DC3D File Offset: 0x0004BE3D
		public IGamepadPointerLure(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040075E8 RID: 30184
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_GamepadPointerLureData_0;

		// Token: 0x040075E9 RID: 30185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040075EA RID: 30186
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040075EB RID: 30187
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040075EC RID: 30188
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x040075ED RID: 30189
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Abstract_Virtual_New_Void_Boolean_0;
	}
}
