using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000701 RID: 1793
	[Serializable]
	public class Impact : Il2CppSystem.Object
	{
		// Token: 0x0600AC35 RID: 44085 RVA: 0x002D53C4 File Offset: 0x002D35C4
		// Note: this type is marked as 'beforefieldinit'.
		static Impact()
		{
			Il2CppClassPointerStore<Impact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Impact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Impact>.NativeClassPtr);
			Impact.NativeFieldInfoPtr_HitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "HitPoint");
			Impact.NativeFieldInfoPtr_ImpactForceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForceDirection");
			Impact.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForce");
			Impact.NativeFieldInfoPtr_ImpactDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactDamage");
			Impact.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactType");
			Impact.NativeFieldInfoPtr_ImpactSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactSource");
			Impact.NativeFieldInfoPtr_ImpactID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactID");
			Impact.NativeFieldInfoPtr_ExplosionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ExplosionType");
			Impact.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100686034);
			Impact.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100686035);
			Impact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100686036);
			Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100686037);
			Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100686038);
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x002D54F8 File Offset: 0x002D36F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295501, RefRangeEnd = 295504, XrefRangeStart = 295494, XrefRangeEnd = 295501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource, int impactID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hitPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForceDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForce;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactDamage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impactSource);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x002D5598 File Offset: 0x002D3798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295511, RefRangeEnd = 295513, XrefRangeStart = 295504, XrefRangeEnd = 295511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact(Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, NetworkObject impactSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hitPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForceDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForce;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactDamage;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impactSource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x002D562C File Offset: 0x002D382C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x002D5668 File Offset: 0x002D3868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295513, RefRangeEnd = 295515, XrefRangeStart = 295513, XrefRangeEnd = 295513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLethal(EImpactType impactType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impactType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x002D56A8 File Offset: 0x002D38A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295527, RefRangeEnd = 295530, XrefRangeStart = 295515, XrefRangeEnd = 295527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerImpact(out Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			player = ((intPtr4 == 0) ? null : new Player(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x0004EB3F File Offset: 0x0004CD3F
		public Impact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600AC3C RID: 44092 RVA: 0x002D5708 File Offset: 0x002D3908
		// (set) Token: 0x0600AC3D RID: 44093 RVA: 0x0004EB48 File Offset: 0x0004CD48
		public unsafe Vector3 HitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint)) = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600AC3E RID: 44094 RVA: 0x002D5730 File Offset: 0x002D3930
		// (set) Token: 0x0600AC3F RID: 44095 RVA: 0x0004EB63 File Offset: 0x0004CD63
		public unsafe Vector3 ImpactForceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection)) = value;
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600AC40 RID: 44096 RVA: 0x002D5758 File Offset: 0x002D3958
		// (set) Token: 0x0600AC41 RID: 44097 RVA: 0x0004EB7E File Offset: 0x0004CD7E
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600AC42 RID: 44098 RVA: 0x002D5780 File Offset: 0x002D3980
		// (set) Token: 0x0600AC43 RID: 44099 RVA: 0x0004EB99 File Offset: 0x0004CD99
		public unsafe float ImpactDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage)) = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600AC44 RID: 44100 RVA: 0x002D57A8 File Offset: 0x002D39A8
		// (set) Token: 0x0600AC45 RID: 44101 RVA: 0x0004EBB4 File Offset: 0x0004CDB4
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600AC46 RID: 44102 RVA: 0x002D57D0 File Offset: 0x002D39D0
		// (set) Token: 0x0600AC47 RID: 44103 RVA: 0x0004EBCF File Offset: 0x0004CDCF
		public unsafe NetworkObject ImpactSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600AC48 RID: 44104 RVA: 0x002D5800 File Offset: 0x002D3A00
		// (set) Token: 0x0600AC49 RID: 44105 RVA: 0x0004EBEE File Offset: 0x0004CDEE
		public unsafe int ImpactID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID)) = value;
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600AC4A RID: 44106 RVA: 0x002D5828 File Offset: 0x002D3A28
		// (set) Token: 0x0600AC4B RID: 44107 RVA: 0x0004EC09 File Offset: 0x0004CE09
		public unsafe EExplosionType ExplosionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ExplosionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ExplosionType)) = value;
			}
		}

		// Token: 0x040076F4 RID: 30452
		private static readonly IntPtr NativeFieldInfoPtr_HitPoint;

		// Token: 0x040076F5 RID: 30453
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForceDirection;

		// Token: 0x040076F6 RID: 30454
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x040076F7 RID: 30455
		private static readonly IntPtr NativeFieldInfoPtr_ImpactDamage;

		// Token: 0x040076F8 RID: 30456
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x040076F9 RID: 30457
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSource;

		// Token: 0x040076FA RID: 30458
		private static readonly IntPtr NativeFieldInfoPtr_ImpactID;

		// Token: 0x040076FB RID: 30459
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionType;

		// Token: 0x040076FC RID: 30460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_Int32_0;

		// Token: 0x040076FD RID: 30461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Single_Single_EImpactType_NetworkObject_0;

		// Token: 0x040076FE RID: 30462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076FF RID: 30463
		private static readonly IntPtr NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0;

		// Token: 0x04007700 RID: 30464
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0;
	}
}
