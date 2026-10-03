using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001AF RID: 431
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06002AD9 RID: 10969 RVA: 0x00108E3C File Offset: 0x0010703C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadEventTransmitter()
		{
			Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadEventTransmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr);
			LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, "onLoadComplete");
			LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668782);
			LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668783);
			LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668784);
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00108EBC File Offset: 0x001070BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124983, XrefRangeEnd = 124995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00108EF0 File Offset: 0x001070F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00108F24 File Offset: 0x00107124
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadEventTransmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0001645D File Offset: 0x0001465D
		public LoadEventTransmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x00108F60 File Offset: 0x00107160
		// (set) Token: 0x06002ADF RID: 10975 RVA: 0x00016466 File Offset: 0x00014666
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
