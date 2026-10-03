using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A7 RID: 167
	public class IUIComponent : Il2CppObjectBase
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x000AC4B4 File Offset: 0x000AA6B4
		// Note: this type is marked as 'beforefieldinit'.
		static IUIComponent()
		{
			Il2CppClassPointerStore<IUIComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "IUIComponent");
			IUIComponent.NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIComponent>.NativeClassPtr, 100665158);
			IUIComponent.NativeMethodInfoPtr_GetDirectionMatch_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIComponent>.NativeClassPtr, 100665159);
			IUIComponent.NativeMethodInfoPtr_GetDistance_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIComponent>.NativeClassPtr, 100665160);
			IUIComponent.NativeMethodInfoPtr_GetOrigin_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUIComponent>.NativeClassPtr, 100665161);
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x000AC52C File Offset: 0x000AA72C
		public unsafe virtual RectTransform RectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIComponent.NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000AC578 File Offset: 0x000AA778
		[CallerCount(0)]
		public unsafe virtual float GetDirectionMatch(Vector2 dir, Vector2 screenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIComponent.NativeMethodInfoPtr_GetDirectionMatch_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000AC5DC File Offset: 0x000AA7DC
		[CallerCount(0)]
		public unsafe virtual float GetDistance(Vector2 screenPos, Vector2 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIComponent.NativeMethodInfoPtr_GetDistance_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000AC640 File Offset: 0x000AA840
		[CallerCount(0)]
		public unsafe virtual Vector3 GetOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUIComponent.NativeMethodInfoPtr_GetOrigin_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00008BDB File Offset: 0x00006DDB
		public IUIComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionMatch_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_GetDistance_Public_Abstract_Virtual_New_Single_Vector2_Vector2_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_GetOrigin_Public_Abstract_Virtual_New_Vector3_0;
	}
}
