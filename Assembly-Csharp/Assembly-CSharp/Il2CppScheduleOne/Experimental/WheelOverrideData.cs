using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Experimental
{
	// Token: 0x020006F6 RID: 1782
	public class WheelOverrideData : ScriptableObject
	{
		// Token: 0x0600ABAC RID: 43948 RVA: 0x002D373C File Offset: 0x002D193C
		// Note: this type is marked as 'beforefieldinit'.
		static WheelOverrideData()
		{
			Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Experimental", "WheelOverrideData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr);
			WheelOverrideData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, "Settings");
			WheelOverrideData.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, "Categories");
			WheelOverrideData.NativeFieldInfoPtr_WheelFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, "WheelFlags");
			WheelOverrideData.NativeFieldInfoPtr_ForwardFrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, "ForwardFrictionFlags");
			WheelOverrideData.NativeFieldInfoPtr_SidewaysFrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, "SidewaysFrictionFlags");
			WheelOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr, 100685972);
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x002D37E4 File Offset: 0x002D19E4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelOverrideData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelOverrideData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelOverrideData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		public WheelOverrideData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600ABAF RID: 43951 RVA: 0x002D3820 File Offset: 0x002D1A20
		// (set) Token: 0x0600ABB0 RID: 43952 RVA: 0x0004E6FD File Offset: 0x0004C8FD
		public unsafe VehicleSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600ABB1 RID: 43953 RVA: 0x002D3850 File Offset: 0x002D1A50
		// (set) Token: 0x0600ABB2 RID: 43954 RVA: 0x0004E71C File Offset: 0x0004C91C
		public unsafe WheelOverrideData.OverrideCategory Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_Categories);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_Categories)) = value;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600ABB3 RID: 43955 RVA: 0x002D3878 File Offset: 0x002D1A78
		// (set) Token: 0x0600ABB4 RID: 43956 RVA: 0x0004E737 File Offset: 0x0004C937
		public unsafe WheelOverrideData.WheelOverrides WheelFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_WheelFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_WheelFlags)) = value;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600ABB5 RID: 43957 RVA: 0x002D38A0 File Offset: 0x002D1AA0
		// (set) Token: 0x0600ABB6 RID: 43958 RVA: 0x0004E752 File Offset: 0x0004C952
		public unsafe WheelOverrideData.WheelFrictionOverrides ForwardFrictionFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_ForwardFrictionFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_ForwardFrictionFlags)) = value;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600ABB7 RID: 43959 RVA: 0x002D38C8 File Offset: 0x002D1AC8
		// (set) Token: 0x0600ABB8 RID: 43960 RVA: 0x0004E76D File Offset: 0x0004C96D
		public unsafe WheelOverrideData.WheelFrictionOverrides SidewaysFrictionFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_SidewaysFrictionFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelOverrideData.NativeFieldInfoPtr_SidewaysFrictionFlags)) = value;
			}
		}

		// Token: 0x04007684 RID: 30340
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04007685 RID: 30341
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04007686 RID: 30342
		private static readonly IntPtr NativeFieldInfoPtr_WheelFlags;

		// Token: 0x04007687 RID: 30343
		private static readonly IntPtr NativeFieldInfoPtr_ForwardFrictionFlags;

		// Token: 0x04007688 RID: 30344
		private static readonly IntPtr NativeFieldInfoPtr_SidewaysFrictionFlags;

		// Token: 0x04007689 RID: 30345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CA4 RID: 3236
		[OriginalName("Assembly-CSharp.dll", "", "OverrideCategory")]
		[Flags]
		public enum OverrideCategory
		{
			// Token: 0x0400A4A5 RID: 42149
			None = 0,
			// Token: 0x0400A4A6 RID: 42150
			Wheels = 1
		}

		// Token: 0x02000CA5 RID: 3237
		[OriginalName("Assembly-CSharp.dll", "", "WheelOverrides")]
		[Flags]
		public enum WheelOverrides
		{
			// Token: 0x0400A4A8 RID: 42152
			None = 0,
			// Token: 0x0400A4A9 RID: 42153
			ForwardFriction = 1,
			// Token: 0x0400A4AA RID: 42154
			SidewaysFriction = 2
		}

		// Token: 0x02000CA6 RID: 3238
		[OriginalName("Assembly-CSharp.dll", "", "WheelFrictionOverrides")]
		[Flags]
		public enum WheelFrictionOverrides
		{
			// Token: 0x0400A4AC RID: 42156
			None = 0,
			// Token: 0x0400A4AD RID: 42157
			ExtremumSlip = 1,
			// Token: 0x0400A4AE RID: 42158
			ExtremumValue = 2,
			// Token: 0x0400A4AF RID: 42159
			AsymptoteSlip = 4,
			// Token: 0x0400A4B0 RID: 42160
			AsymptoteValue = 8,
			// Token: 0x0400A4B1 RID: 42161
			Stiffness = 16
		}
	}
}
