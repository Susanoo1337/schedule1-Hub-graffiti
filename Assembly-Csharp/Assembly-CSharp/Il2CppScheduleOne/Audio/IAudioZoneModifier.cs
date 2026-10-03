using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000477 RID: 1143
	public class IAudioZoneModifier : Il2CppObjectBase
	{
		// Token: 0x06006760 RID: 26464 RVA: 0x00030BCD File Offset: 0x0002EDCD
		// Note: this type is marked as 'beforefieldinit'.
		static IAudioZoneModifier()
		{
			Il2CppClassPointerStore<IAudioZoneModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "IAudioZoneModifier");
			IAudioZoneModifier.NativeMethodInfoPtr_get_VolumeMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAudioZoneModifier>.NativeClassPtr, 100676808);
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06006761 RID: 26465 RVA: 0x001E0E24 File Offset: 0x001DF024
		public unsafe virtual float VolumeMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAudioZoneModifier.NativeMethodInfoPtr_get_VolumeMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x00030BFC File Offset: 0x0002EDFC
		public IAudioZoneModifier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004724 RID: 18212
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeMultiplier_Public_Abstract_Virtual_New_get_Single_0;
	}
}
