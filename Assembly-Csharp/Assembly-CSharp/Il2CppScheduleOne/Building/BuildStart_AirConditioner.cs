using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Temperature;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200045A RID: 1114
	public class BuildStart_AirConditioner : BuildStart_Grid
	{
		// Token: 0x0600651F RID: 25887 RVA: 0x001D9CA8 File Offset: 0x001D7EA8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_AirConditioner()
		{
			Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_AirConditioner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr);
			BuildStart_AirConditioner.NativeFieldInfoPtr_ac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr, "ac");
			BuildStart_AirConditioner.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr, 100676578);
			BuildStart_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr, 100676579);
			BuildStart_AirConditioner.NativeMethodInfoPtr__StartBuilding_b__1_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr, 100676580);
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x001D9D28 File Offset: 0x001D7F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211703, XrefRangeEnd = 211764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_AirConditioner.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x001D9D78 File Offset: 0x001D7F78
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_AirConditioner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_AirConditioner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_AirConditioner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x001D9DB4 File Offset: 0x001D7FB4
		[CallerCount(0)]
		public unsafe float _StartBuilding_b__1_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_AirConditioner.NativeMethodInfoPtr__StartBuilding_b__1_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x0002FA52 File Offset: 0x0002DC52
		public BuildStart_AirConditioner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x001D9DF0 File Offset: 0x001D7FF0
		// (set) Token: 0x06006525 RID: 25893 RVA: 0x0002FA5B File Offset: 0x0002DC5B
		public unsafe AirConditioner ac
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_AirConditioner.NativeFieldInfoPtr_ac);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AirConditioner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildStart_AirConditioner.NativeFieldInfoPtr_ac), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045B4 RID: 17844
		private static readonly IntPtr NativeFieldInfoPtr_ac;

		// Token: 0x040045B5 RID: 17845
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040045B6 RID: 17846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045B7 RID: 17847
		private static readonly IntPtr NativeMethodInfoPtr__StartBuilding_b__1_0_Private_Single_0;
	}
}
