using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006FF RID: 1791
	public class IDamageable : Il2CppObjectBase
	{
		// Token: 0x0600AC30 RID: 44080 RVA: 0x002D5274 File Offset: 0x002D3474
		// Note: this type is marked as 'beforefieldinit'.
		static IDamageable()
		{
			Il2CppClassPointerStore<IDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "IDamageable");
			IDamageable.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100686031);
			IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100686032);
			IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100686033);
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600AC31 RID: 44081 RVA: 0x002D52D8 File Offset: 0x002D34D8
		public unsafe virtual GameObject gameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x002D5324 File Offset: 0x002D3524
		[CallerCount(0)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x002D5374 File Offset: 0x002D3574
		[CallerCount(0)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0004EB36 File Offset: 0x0004CD36
		public IDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040076EA RID: 30442
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_Abstract_Virtual_New_get_GameObject_0;

		// Token: 0x040076EB RID: 30443
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0;

		// Token: 0x040076EC RID: 30444
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0;
	}
}
