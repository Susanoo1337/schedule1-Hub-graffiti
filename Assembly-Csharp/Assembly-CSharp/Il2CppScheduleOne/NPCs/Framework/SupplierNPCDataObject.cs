using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000606 RID: 1542
	public class SupplierNPCDataObject : GenericNPCDataObject<SupplierNPCData>
	{
		// Token: 0x06009617 RID: 38423 RVA: 0x00286D2C File Offset: 0x00284F2C
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierNPCDataObject()
		{
			Il2CppClassPointerStore<SupplierNPCDataObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "SupplierNPCDataObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierNPCDataObject>.NativeClassPtr);
			SupplierNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierNPCDataObject>.NativeClassPtr, 100682870);
			SupplierNPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierNPCDataObject>.NativeClassPtr, 100682871);
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x00286D84 File Offset: 0x00284F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272858, XrefRangeEnd = 272863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SupplierNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x00286DC0 File Offset: 0x00284FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272863, XrefRangeEnd = 272866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierNPCDataObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierNPCDataObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierNPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600961A RID: 38426 RVA: 0x00046426 File Offset: 0x00044626
		public SupplierNPCDataObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400673E RID: 26430
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x0400673F RID: 26431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
