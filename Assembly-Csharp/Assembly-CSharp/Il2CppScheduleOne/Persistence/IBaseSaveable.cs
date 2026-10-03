using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001AB RID: 427
	public class IBaseSaveable : Il2CppObjectBase
	{
		// Token: 0x06002AB4 RID: 10932 RVA: 0x000163D1 File Offset: 0x000145D1
		// Note: this type is marked as 'beforefieldinit'.
		static IBaseSaveable()
		{
			Il2CppClassPointerStore<IBaseSaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "IBaseSaveable");
			IBaseSaveable.NativeMethodInfoPtr_get_LoadOrder_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseSaveable>.NativeClassPtr, 100668753);
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x00108270 File Offset: 0x00106470
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseSaveable.NativeMethodInfoPtr_get_LoadOrder_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00016400 File Offset: 0x00014600
		public IBaseSaveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
