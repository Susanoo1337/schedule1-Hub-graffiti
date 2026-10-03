using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000F0 RID: 240
	public class VehicleTeleporter : MonoBehaviour
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x000C8378 File Offset: 0x000C6578
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleTeleporter()
		{
			Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100666504);
			VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100666505);
			VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr, 100666506);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000C83E4 File Offset: 0x000C65E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97118, RefRangeEnd = 97119, XrefRangeStart = 97092, XrefRangeEnd = 97118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToGraph(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000C8424 File Offset: 0x000C6624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97145, RefRangeEnd = 97146, XrefRangeStart = 97119, XrefRangeEnd = 97145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToRoadNetwork(bool resetRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000C8464 File Offset: 0x000C6664
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0000CD83 File Offset: 0x0000AF83
		public VehicleTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr_MoveToGraph_Public_Void_Boolean_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_MoveToRoadNetwork_Public_Void_Boolean_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
