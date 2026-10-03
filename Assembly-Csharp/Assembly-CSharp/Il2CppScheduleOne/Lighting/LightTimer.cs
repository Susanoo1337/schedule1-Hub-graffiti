using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DD RID: 989
	public class LightTimer : MonoBehaviour
	{
		// Token: 0x06005879 RID: 22649 RVA: 0x001AD668 File Offset: 0x001AB868
		// Note: this type is marked as 'beforefieldinit'.
		static LightTimer()
		{
			Il2CppClassPointerStore<LightTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightTimer>.NativeClassPtr);
			LightTimer.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTime");
			LightTimer.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "EndTime");
			LightTimer.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "StartTimeOffset");
			LightTimer.NativeFieldInfoPtr_toggleableLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, "toggleableLights");
			LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674914);
			LightTimer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674915);
			LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674916);
			LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674917);
			LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674918);
			LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightTimer>.NativeClassPtr, 100674919);
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x001AD760 File Offset: 0x001AB960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193189, XrefRangeEnd = 193204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x001AD79C File Offset: 0x001AB99C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x001AD7D0 File Offset: 0x001AB9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193204, XrefRangeEnd = 193211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightTimer.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x001AD80C File Offset: 0x001ABA0C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x001AD840 File Offset: 0x001ABA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193211, XrefRangeEnd = 193213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x001AD880 File Offset: 0x001ABA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193213, XrefRangeEnd = 193214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightTimer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x00029D24 File Offset: 0x00027F24
		public LightTimer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x001AD8BC File Offset: 0x001ABABC
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x00029D2D File Offset: 0x00027F2D
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x001AD8E4 File Offset: 0x001ABAE4
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x00029D48 File Offset: 0x00027F48
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x001AD90C File Offset: 0x001ABB0C
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x00029D63 File Offset: 0x00027F63
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x001AD934 File Offset: 0x001ABB34
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x00029D7E File Offset: 0x00027F7E
		public unsafe Il2CppReferenceArray<ToggleableLight> toggleableLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightTimer.NativeFieldInfoPtr_toggleableLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeFieldInfoPtr_toggleableLights;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
