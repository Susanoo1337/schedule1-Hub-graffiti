using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E2 RID: 1762
	public class IGamepadPointerHandler : Il2CppObjectBase
	{
		// Token: 0x0600AA6A RID: 43626 RVA: 0x002D0244 File Offset: 0x002CE444
		// Note: this type is marked as 'beforefieldinit'.
		static IGamepadPointerHandler()
		{
			Il2CppClassPointerStore<IGamepadPointerHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "IGamepadPointerHandler");
			IGamepadPointerHandler.NativeMethodInfoPtr_Initialise_Public_Abstract_Virtual_New_Void_GamepadPointer_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerHandler>.NativeClassPtr, 100685898);
			IGamepadPointerHandler.NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGamepadPointerHandler>.NativeClassPtr, 100685899);
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x002D0294 File Offset: 0x002CE494
		[CallerCount(0)]
		public unsafe virtual void Initialise(GamepadPointer manager, float maxFriction, AnimationCurve frictionCurve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFriction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frictionCurve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerHandler.NativeMethodInfoPtr_Initialise_Public_Abstract_Virtual_New_Void_GamepadPointer_Single_AnimationCurve_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x002D0304 File Offset: 0x002CE504
		[CallerCount(0)]
		public unsafe virtual Vector2 GetPosition(Vector2 rawInput, Vector2 pointerPosition, float speed, bool isAimAssistActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rawInput;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAimAssistActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGamepadPointerHandler.NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_Vector2_Vector2_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x0004DAE0 File Offset: 0x0004BCE0
		public IGamepadPointerHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040075CC RID: 30156
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Abstract_Virtual_New_Void_GamepadPointer_Single_AnimationCurve_0;

		// Token: 0x040075CD RID: 30157
		private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Abstract_Virtual_New_Vector2_Vector2_Vector2_Single_Boolean_0;
	}
}
