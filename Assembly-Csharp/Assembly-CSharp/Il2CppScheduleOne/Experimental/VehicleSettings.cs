using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F4 RID: 1780
	[Serializable]
	public class VehicleSettings : Object
	{
		// Token: 0x0600AB95 RID: 43925 RVA: 0x002D334C File Offset: 0x002D154C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSettings()
		{
			Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "VehicleSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr);
			VehicleSettings.NativeFieldInfoPtr_ForwardFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "ForwardFriction");
			VehicleSettings.NativeFieldInfoPtr_SidewaysFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, "SidewaysFriction");
			VehicleSettings.NativeMethodInfoPtr_Clone_Public_VehicleSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100685967);
			VehicleSettings.NativeMethodInfoPtr_Blend_Public_VehicleSettings_VehicleSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100685968);
			VehicleSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr, 100685969);
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x002D33E0 File Offset: 0x002D15E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294997, RefRangeEnd = 294998, XrefRangeStart = 294984, XrefRangeEnd = 294997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSettings.NativeMethodInfoPtr_Clone_Public_VehicleSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleSettings>(intPtr3) : null;
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x002D3420 File Offset: 0x002D1620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295006, RefRangeEnd = 295007, XrefRangeStart = 294998, XrefRangeEnd = 295006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSettings Blend(VehicleSettings other, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSettings.NativeMethodInfoPtr_Blend_Public_VehicleSettings_VehicleSettings_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleSettings>(intPtr3) : null;
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x002D3480 File Offset: 0x002D1680
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295018, RefRangeEnd = 295021, XrefRangeStart = 295007, XrefRangeEnd = 295018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB99 RID: 43929 RVA: 0x0004E61D File Offset: 0x0004C81D
		public VehicleSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x002D34BC File Offset: 0x002D16BC
		// (set) Token: 0x0600AB9B RID: 43931 RVA: 0x0004E626 File Offset: 0x0004C826
		public unsafe WheelFrictionSettings ForwardFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSettings.NativeFieldInfoPtr_ForwardFriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelFrictionSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSettings.NativeFieldInfoPtr_ForwardFriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x002D34EC File Offset: 0x002D16EC
		// (set) Token: 0x0600AB9D RID: 43933 RVA: 0x0004E645 File Offset: 0x0004C845
		public unsafe WheelFrictionSettings SidewaysFriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSettings.NativeFieldInfoPtr_SidewaysFriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelFrictionSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSettings.NativeFieldInfoPtr_SidewaysFriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007678 RID: 30328
		private static readonly IntPtr NativeFieldInfoPtr_ForwardFriction;

		// Token: 0x04007679 RID: 30329
		private static readonly IntPtr NativeFieldInfoPtr_SidewaysFriction;

		// Token: 0x0400767A RID: 30330
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_VehicleSettings_0;

		// Token: 0x0400767B RID: 30331
		private static readonly IntPtr NativeMethodInfoPtr_Blend_Public_VehicleSettings_VehicleSettings_Single_0;

		// Token: 0x0400767C RID: 30332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
