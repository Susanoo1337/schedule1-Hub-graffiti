using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B1 RID: 689
	public class DarkMarketAccessZone : TimedAccessZone
	{
		// Token: 0x06003576 RID: 13686 RVA: 0x0012D5A4 File Offset: 0x0012B7A4
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketAccessZone()
		{
			Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr);
			DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100670083);
			DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100670084);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0012D5FC File Offset: 0x0012B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141475, XrefRangeEnd = 141483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0012D644 File Offset: 0x0012B844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141483, XrefRangeEnd = 141484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0001B251 File Offset: 0x00019451
		public DarkMarketAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
