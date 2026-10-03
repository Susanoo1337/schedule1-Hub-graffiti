using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BE RID: 702
	public class MedicalCentre : NPCEnterableBuilding
	{
		// Token: 0x06003674 RID: 13940 RVA: 0x00130398 File Offset: 0x0012E598
		// Note: this type is marked as 'beforefieldinit'.
		static MedicalCentre()
		{
			Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MedicalCentre");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr);
			MedicalCentre.NativeFieldInfoPtr_RespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, "RespawnPoint");
			MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr, 100670178);
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x001303F0 File Offset: 0x0012E5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142240, RefRangeEnd = 142241, XrefRangeStart = 142229, XrefRangeEnd = 142240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MedicalCentre() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedicalCentre>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MedicalCentre.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x0001BAE6 File Offset: 0x00019CE6
		public MedicalCentre(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x0013042C File Offset: 0x0012E62C
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x0001BAEF File Offset: 0x00019CEF
		public unsafe Transform RespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MedicalCentre.NativeFieldInfoPtr_RespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002473 RID: 9331
		private static readonly IntPtr NativeFieldInfoPtr_RespawnPoint;

		// Token: 0x04002474 RID: 9332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
