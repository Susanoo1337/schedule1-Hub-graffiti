using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020002CE RID: 718
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x0600385A RID: 14426 RVA: 0x00136B9C File Offset: 0x00134D9C
		// Note: this type is marked as 'beforefieldinit'.
		static StreetLight()
		{
			Il2CppClassPointerStore<StreetLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "StreetLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetLight>.NativeClassPtr);
			StreetLight.NativeFieldInfoPtr_PowerOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "PowerOrigin");
			StreetLight.NativeFieldInfoPtr__lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "_lights");
			StreetLight.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTime");
			StreetLight.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "EndTime");
			StreetLight.NativeFieldInfoPtr__startTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "_startTimeOffset");
			StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100670434);
			StreetLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100670435);
			StreetLight.NativeMethodInfoPtr_UpdateState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100670436);
			StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100670437);
			StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100670438);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00136C94 File Offset: 0x00134E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144823, XrefRangeEnd = 144849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00136CD0 File Offset: 0x00134ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144849, XrefRangeEnd = 144861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00136D04 File Offset: 0x00134F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_UpdateState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00136D38 File Offset: 0x00134F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144861, XrefRangeEnd = 144863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00136D78 File Offset: 0x00134F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144863, XrefRangeEnd = 144864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0001C921 File Offset: 0x0001AB21
		public StreetLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x00136DB4 File Offset: 0x00134FB4
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x0001C92A File Offset: 0x0001AB2A
		public unsafe static Vector3 PowerOrigin
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(StreetLight.NativeFieldInfoPtr_PowerOrigin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreetLight.NativeFieldInfoPtr_PowerOrigin, (void*)(&value));
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x00136DD0 File Offset: 0x00134FD0
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x0001C938 File Offset: 0x0001AB38
		public unsafe Il2CppReferenceArray<ToggleableLight> _lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr__lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr__lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x00136E00 File Offset: 0x00135000
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0001C957 File Offset: 0x0001AB57
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x00136E28 File Offset: 0x00135028
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0001C972 File Offset: 0x0001AB72
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x00136E50 File Offset: 0x00135050
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0001C98D File Offset: 0x0001AB8D
		public unsafe int _startTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr__startTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr__startTimeOffset)) = value;
			}
		}

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr_PowerOrigin;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr__lights;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeFieldInfoPtr__startTimeOffset;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Private_Void_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
