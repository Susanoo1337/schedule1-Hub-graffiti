using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B3 RID: 691
	public class Dealership : MonoBehaviour
	{
		// Token: 0x06003597 RID: 13719 RVA: 0x0012DBD0 File Offset: 0x0012BDD0
		// Note: this type is marked as 'beforefieldinit'.
		static Dealership()
		{
			Il2CppClassPointerStore<Dealership>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Dealership");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealership>.NativeClassPtr);
			Dealership.NativeFieldInfoPtr_SpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealership>.NativeClassPtr, "SpawnPoints");
			Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100670100);
			Dealership.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealership>.NativeClassPtr, 100670101);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0012DC3C File Offset: 0x0012BE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141620, XrefRangeEnd = 141628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0012DC80 File Offset: 0x0012BE80
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealership() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealership>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealership.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0001B376 File Offset: 0x00019576
		public Dealership(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x0012DCBC File Offset: 0x0012BEBC
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x0001B37F File Offset: 0x0001957F
		public unsafe Il2CppReferenceArray<Transform> SpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealership.NativeFieldInfoPtr_SpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoints;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
