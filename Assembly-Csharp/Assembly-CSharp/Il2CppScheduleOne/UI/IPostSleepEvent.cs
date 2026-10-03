using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000751 RID: 1873
	public class IPostSleepEvent : Il2CppObjectBase
	{
		// Token: 0x0600B6B3 RID: 46771 RVA: 0x002F48E0 File Offset: 0x002F2AE0
		// Note: this type is marked as 'beforefieldinit'.
		static IPostSleepEvent()
		{
			Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "IPostSleepEvent");
			IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100687193);
			IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100687194);
			IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100687195);
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600B6B4 RID: 46772 RVA: 0x002F4944 File Offset: 0x002F2B44
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600B6B5 RID: 46773 RVA: 0x002F498C File Offset: 0x002F2B8C
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x002F49D4 File Offset: 0x002F2BD4
		[CallerCount(0)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x00054C36 File Offset: 0x00052E36
		public IPostSleepEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007D8C RID: 32140
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04007D8D RID: 32141
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04007D8E RID: 32142
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0;
	}
}
