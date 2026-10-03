using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000341 RID: 833
	public class ClipboardSlot : HotbarSlot
	{
		// Token: 0x060047A3 RID: 18339 RVA: 0x0016E7A8 File Offset: 0x0016C9A8
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardSlot()
		{
			Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ClipboardSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr);
			ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100672467);
			ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100672468);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0016E800 File Offset: 0x0016CA00
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x0016E84C File Offset: 0x0016CA4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140320, RefRangeEnd = 140322, XrefRangeStart = 140320, XrefRangeEnd = 140322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00022FC2 File Offset: 0x000211C2
		public ClipboardSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
