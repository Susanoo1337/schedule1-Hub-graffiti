using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006FD RID: 1789
	[StructLayout(2)]
	public struct ExplosionData
	{
		// Token: 0x0600AC1B RID: 44059 RVA: 0x002D4C64 File Offset: 0x002D2E64
		// Note: this type is marked as 'beforefieldinit'.
		static ExplosionData()
		{
			Il2CppClassPointerStore<ExplosionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ExplosionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr);
			ExplosionData.NativeFieldInfoPtr_DamageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DamageRadius");
			ExplosionData.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxDamage");
			ExplosionData.NativeFieldInfoPtr_PushForceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "PushForceRadius");
			ExplosionData.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxPushForce");
			ExplosionData.NativeFieldInfoPtr_CheckLoS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "CheckLoS");
			ExplosionData.NativeFieldInfoPtr_ExplosionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "ExplosionType");
			ExplosionData.NativeFieldInfoPtr_DefaultSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DefaultSmall");
			ExplosionData.NativeFieldInfoPtr_LightningStrike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "LightningStrike");
			ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_EExplosionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, 100686017);
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x002D4D48 File Offset: 0x002D2F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295471, RefRangeEnd = 295474, XrefRangeStart = 295471, XrefRangeEnd = 295471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExplosionData(float damageRadius, float maxDamage, float maxPushForce, bool checkLoS, EExplosionType explosionType = EExplosionType.Default)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damageRadius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDamage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPushForce;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkLoS;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref explosionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_EExplosionType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC1D RID: 44061 RVA: 0x0004EAFF File Offset: 0x0004CCFF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, ref this));
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x002D4DB4 File Offset: 0x002D2FB4
		// (set) Token: 0x0600AC1F RID: 44063 RVA: 0x0004EB11 File Offset: 0x0004CD11
		public unsafe static ExplosionData DefaultSmall
		{
			get
			{
				ExplosionData result;
				IL2CPP.il2cpp_field_static_get_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&value));
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600AC20 RID: 44064 RVA: 0x002D4DD0 File Offset: 0x002D2FD0
		// (set) Token: 0x0600AC21 RID: 44065 RVA: 0x0004EB1F File Offset: 0x0004CD1F
		public unsafe static ExplosionData LightningStrike
		{
			get
			{
				ExplosionData result;
				IL2CPP.il2cpp_field_static_get_value(ExplosionData.NativeFieldInfoPtr_LightningStrike, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExplosionData.NativeFieldInfoPtr_LightningStrike, (void*)(&value));
			}
		}

		// Token: 0x040076CF RID: 30415
		private static readonly IntPtr NativeFieldInfoPtr_DamageRadius;

		// Token: 0x040076D0 RID: 30416
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x040076D1 RID: 30417
		private static readonly IntPtr NativeFieldInfoPtr_PushForceRadius;

		// Token: 0x040076D2 RID: 30418
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x040076D3 RID: 30419
		private static readonly IntPtr NativeFieldInfoPtr_CheckLoS;

		// Token: 0x040076D4 RID: 30420
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionType;

		// Token: 0x040076D5 RID: 30421
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSmall;

		// Token: 0x040076D6 RID: 30422
		private static readonly IntPtr NativeFieldInfoPtr_LightningStrike;

		// Token: 0x040076D7 RID: 30423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_EExplosionType_0;

		// Token: 0x040076D8 RID: 30424
		[FieldOffset(0)]
		public float DamageRadius;

		// Token: 0x040076D9 RID: 30425
		[FieldOffset(4)]
		public float MaxDamage;

		// Token: 0x040076DA RID: 30426
		[FieldOffset(8)]
		public float PushForceRadius;

		// Token: 0x040076DB RID: 30427
		[FieldOffset(12)]
		public float MaxPushForce;

		// Token: 0x040076DC RID: 30428
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool CheckLoS;

		// Token: 0x040076DD RID: 30429
		[FieldOffset(20)]
		public EExplosionType ExplosionType;
	}
}
