using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002CA RID: 714
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x06003803 RID: 14339 RVA: 0x001359B0 File Offset: 0x00133BB0
		// Note: this type is marked as 'beforefieldinit'.
		static TimedAccessZone()
		{
			Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "TimedAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr);
			TimedAccessZone.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "OpenTime");
			TimedAccessZone.NativeFieldInfoPtr_CloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "CloseTime");
			TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100670379);
			TimedAccessZone.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100670380);
			TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100670381);
			TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100670382);
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x00135A58 File Offset: 0x00133C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144274, XrefRangeEnd = 144285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00135A94 File Offset: 0x00133C94
		[CallerCount(0)]
		public unsafe virtual void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x00135AD0 File Offset: 0x00133CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144291, RefRangeEnd = 144292, XrefRangeStart = 144285, XrefRangeEnd = 144291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00135B18 File Offset: 0x00133D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144293, RefRangeEnd = 144294, XrefRangeStart = 144292, XrefRangeEnd = 144293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x0001C66E File Offset: 0x0001A86E
		public TimedAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00135B54 File Offset: 0x00133D54
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x0001C677 File Offset: 0x0001A877
		public unsafe int OpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime)) = value;
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x00135B7C File Offset: 0x00133D7C
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x0001C692 File Offset: 0x0001A892
		public unsafe int CloseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime)) = value;
			}
		}

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr_CloseTime;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
