using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031E RID: 798
	public static class PenaltyHandler : Object
	{
		// Token: 0x06003ECB RID: 16075 RVA: 0x0014EA88 File Offset: 0x0014CC88
		// Note: this type is marked as 'beforefieldinit'.
		static PenaltyHandler()
		{
			Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PenaltyHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr);
			PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "CONTROLLED_SUBSTANCE_FINE");
			PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "LOW_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "MED_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "HIGH_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "FAILURE_TO_COMPLY_FINE");
			PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "EVADING_ARREST_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VIOLATING_CURFEW_TIME");
			PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ATTEMPT_TO_SELL_FINE");
			PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DEADLY_ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VANDALISM_FINE");
			PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "THEFT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "BRANDISHING_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DISCHARGE_FIREARM_FINE");
			PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, 100671283);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0014EBE4 File Offset: 0x0014CDE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153116, RefRangeEnd = 153117, XrefRangeStart = 153000, XrefRangeEnd = 153116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crimes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0001F33D File Offset: 0x0001D53D
		public PenaltyHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x0014EC28 File Offset: 0x0014CE28
		// (set) Token: 0x06003ECF RID: 16079 RVA: 0x0001F346 File Offset: 0x0001D546
		public unsafe static float CONTROLLED_SUBSTANCE_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06003ED0 RID: 16080 RVA: 0x0014EC44 File Offset: 0x0014CE44
		// (set) Token: 0x06003ED1 RID: 16081 RVA: 0x0001F354 File Offset: 0x0001D554
		public unsafe static float LOW_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06003ED2 RID: 16082 RVA: 0x0014EC60 File Offset: 0x0014CE60
		// (set) Token: 0x06003ED3 RID: 16083 RVA: 0x0001F362 File Offset: 0x0001D562
		public unsafe static float MED_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06003ED4 RID: 16084 RVA: 0x0014EC7C File Offset: 0x0014CE7C
		// (set) Token: 0x06003ED5 RID: 16085 RVA: 0x0001F370 File Offset: 0x0001D570
		public unsafe static float HIGH_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x0014EC98 File Offset: 0x0014CE98
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x0001F37E File Offset: 0x0001D57E
		public unsafe static float FAILURE_TO_COMPLY_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x0014ECB4 File Offset: 0x0014CEB4
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x0001F38C File Offset: 0x0001D58C
		public unsafe static float EVADING_ARREST_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x0014ECD0 File Offset: 0x0014CED0
		// (set) Token: 0x06003EDB RID: 16091 RVA: 0x0001F39A File Offset: 0x0001D59A
		public unsafe static float VIOLATING_CURFEW_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06003EDC RID: 16092 RVA: 0x0014ECEC File Offset: 0x0014CEEC
		// (set) Token: 0x06003EDD RID: 16093 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
		public unsafe static float ATTEMPT_TO_SELL_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0014ED08 File Offset: 0x0014CF08
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x0001F3B6 File Offset: 0x0001D5B6
		public unsafe static float ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x0014ED24 File Offset: 0x0014CF24
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x0001F3C4 File Offset: 0x0001D5C4
		public unsafe static float DEADLY_ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06003EE2 RID: 16098 RVA: 0x0014ED40 File Offset: 0x0014CF40
		// (set) Token: 0x06003EE3 RID: 16099 RVA: 0x0001F3D2 File Offset: 0x0001D5D2
		public unsafe static float VANDALISM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x0014ED5C File Offset: 0x0014CF5C
		// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		public unsafe static float THEFT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x0014ED78 File Offset: 0x0014CF78
		// (set) Token: 0x06003EE7 RID: 16103 RVA: 0x0001F3EE File Offset: 0x0001D5EE
		public unsafe static float BRANDISHING_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&value));
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x0014ED94 File Offset: 0x0014CF94
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		public unsafe static float DISCHARGE_FIREARM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&value));
			}
		}

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeFieldInfoPtr_EVADING_ARREST_FINE;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeFieldInfoPtr_VIOLATING_CURFEW_TIME;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_FINE;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeFieldInfoPtr_DEADLY_ASSAULT_FINE;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeFieldInfoPtr_VANDALISM_FINE;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeFieldInfoPtr_THEFT_FINE;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeFieldInfoPtr_BRANDISHING_FINE;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0;
	}
}
