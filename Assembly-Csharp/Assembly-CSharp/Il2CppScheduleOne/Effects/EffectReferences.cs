using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006A5 RID: 1701
	public static class EffectReferences : Object
	{
		// Token: 0x0600A5E9 RID: 42473 RVA: 0x0004BBF4 File Offset: 0x00049DF4
		// Note: this type is marked as 'beforefieldinit'.
		static EffectReferences()
		{
			Il2CppClassPointerStore<EffectReferences>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "EffectReferences");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectReferences>.NativeClassPtr);
			EffectReferences.NativeFieldInfoPtr_PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectReferences>.NativeClassPtr, "PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME");
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x0004BC2D File Offset: 0x00049E2D
		public EffectReferences(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x0600A5EB RID: 42475 RVA: 0x002C0468 File Offset: 0x002BE668
		// (set) Token: 0x0600A5EC RID: 42476 RVA: 0x0004BC36 File Offset: 0x00049E36
		public unsafe static string PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectReferences.NativeFieldInfoPtr_PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectReferences.NativeFieldInfoPtr_PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040072C3 RID: 29379
		private static readonly IntPtr NativeFieldInfoPtr_PARTICLE_SYSTEM_EMISSION_RATE_OVER_TIME;
	}
}
