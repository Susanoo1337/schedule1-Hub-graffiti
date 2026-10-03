using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000198 RID: 408
	public class ISightable : Il2CppObjectBase
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x00103650 File Offset: 0x00101850
		// Note: this type is marked as 'beforefieldinit'.
		static ISightable()
		{
			Il2CppClassPointerStore<ISightable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "ISightable");
			ISightable.NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISightable>.NativeClassPtr, 100668582);
			ISightable.NativeMethodInfoPtr_get_HighestProgressionEvent_Public_Abstract_Virtual_New_get_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISightable>.NativeClassPtr, 100668583);
			ISightable.NativeMethodInfoPtr_set_HighestProgressionEvent_Public_Abstract_Virtual_New_set_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISightable>.NativeClassPtr, 100668584);
			ISightable.NativeMethodInfoPtr_get_VisibilityComponent_Public_Abstract_Virtual_New_get_EntityVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISightable>.NativeClassPtr, 100668585);
			ISightable.NativeMethodInfoPtr_IsCurrentlySightable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISightable>.NativeClassPtr, 100668586);
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x001036DC File Offset: 0x001018DC
		public unsafe virtual NetworkObject NetworkObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISightable.NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00103728 File Offset: 0x00101928
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00103774 File Offset: 0x00101974
		public unsafe virtual VisionEvent HighestProgressionEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISightable.NativeMethodInfoPtr_get_HighestProgressionEvent_Public_Abstract_Virtual_New_get_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISightable.NativeMethodInfoPtr_set_HighestProgressionEvent_Public_Abstract_Virtual_New_set_Void_VisionEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x001037C4 File Offset: 0x001019C4
		public unsafe virtual EntityVisibility VisibilityComponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISightable.NativeMethodInfoPtr_get_VisibilityComponent_Public_Abstract_Virtual_New_get_EntityVisibility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityVisibility>(intPtr3) : null;
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00103810 File Offset: 0x00101A10
		[CallerCount(0)]
		public unsafe virtual bool IsCurrentlySightable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISightable.NativeMethodInfoPtr_IsCurrentlySightable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x000159BA File Offset: 0x00013BBA
		public ISightable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_HighestProgressionEvent_Public_Abstract_Virtual_New_get_VisionEvent_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_set_HighestProgressionEvent_Public_Abstract_Virtual_New_set_Void_VisionEvent_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_get_VisibilityComponent_Public_Abstract_Virtual_New_get_EntityVisibility_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentlySightable_Public_Abstract_Virtual_New_Boolean_0;
	}
}
