using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200039F RID: 927
	public class SupplierLocationConfiguration : MonoBehaviour
	{
		// Token: 0x06005436 RID: 21558 RVA: 0x0019EDC4 File Offset: 0x0019CFC4
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocationConfiguration()
		{
			Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr);
			SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, "SupplierID");
			SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100674367);
			SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100674368);
			SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr, 100674369);
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x0019EE44 File Offset: 0x0019D044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187971, RefRangeEnd = 187972, XrefRangeStart = 187968, XrefRangeEnd = 187971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x0019EE78 File Offset: 0x0019D078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187975, RefRangeEnd = 187977, XrefRangeStart = 187972, XrefRangeEnd = 187975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x0019EEAC File Offset: 0x0019D0AC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocationConfiguration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00027C9F File Offset: 0x00025E9F
		public SupplierLocationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x0019EEE8 File Offset: 0x0019D0E8
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x00027CA8 File Offset: 0x00025EA8
		public unsafe string SupplierID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocationConfiguration.NativeFieldInfoPtr_SupplierID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003A0B RID: 14859
		private static readonly IntPtr NativeFieldInfoPtr_SupplierID;

		// Token: 0x04003A0C RID: 14860
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04003A0D RID: 14861
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04003A0E RID: 14862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
