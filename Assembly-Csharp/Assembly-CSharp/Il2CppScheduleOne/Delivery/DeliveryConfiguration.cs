using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Configuration;
using Il2CppScheduleOne.Core.Deliveries;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x02000417 RID: 1047
	public class DeliveryConfiguration : Configuration<DeliverySettings>
	{
		// Token: 0x06005C5B RID: 23643 RVA: 0x0002BC51 File Offset: 0x00029E51
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryConfiguration()
		{
			Il2CppClassPointerStore<DeliveryConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryConfiguration>.NativeClassPtr);
			DeliveryConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryConfiguration>.NativeClassPtr, 100675354);
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x001B983C File Offset: 0x001B7A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198457, XrefRangeEnd = 198460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x0002BC8A File Offset: 0x00029E8A
		public DeliveryConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003F55 RID: 16213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
