using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000292 RID: 658
	public sealed class HostPasswordBroadcast : ValueType
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x00019E50 File Offset: 0x00018050
		// Note: this type is marked as 'beforefieldinit'.
		static HostPasswordBroadcast()
		{
			Il2CppClassPointerStore<HostPasswordBroadcast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "HostPasswordBroadcast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HostPasswordBroadcast>.NativeClassPtr);
			HostPasswordBroadcast.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HostPasswordBroadcast>.NativeClassPtr, "Password");
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00019E89 File Offset: 0x00018089
		public HostPasswordBroadcast(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00019E92 File Offset: 0x00018092
		public HostPasswordBroadcast() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HostPasswordBroadcast>.NativeClassPtr))
		{
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06003238 RID: 12856 RVA: 0x00120DD4 File Offset: 0x0011EFD4
		// (set) Token: 0x06003239 RID: 12857 RVA: 0x00019EA4 File Offset: 0x000180A4
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HostPasswordBroadcast.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HostPasswordBroadcast.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeFieldInfoPtr_Password;
	}
}
