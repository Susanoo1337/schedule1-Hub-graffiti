using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppLiquidVolumeFX;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200053C RID: 1340
	public class LiquidContainer : MonoBehaviour
	{
		// Token: 0x060079D5 RID: 31189 RVA: 0x0021BF7C File Offset: 0x0021A17C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidContainer()
		{
			Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr);
			LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<CurrentLiquidLevel>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "<LiquidColor>k__BackingField");
			LiquidContainer.NativeFieldInfoPtr_Viscosity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Viscosity");
			LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "AdjustMurkiness");
			LiquidContainer.NativeFieldInfoPtr_LiquidVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "LiquidVolume");
			LiquidContainer.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "Collider");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Min");
			LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "ColliderTransform_Max");
			LiquidContainer.NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "MaxLevel");
			LiquidContainer.NativeFieldInfoPtr_liquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, "liquidMesh");
			LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678954);
			LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678955);
			LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678956);
			LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678957);
			LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678958);
			LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678959);
			LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678960);
			LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678961);
			LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678962);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678963);
			LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678964);
			LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr, 100678965);
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x0021C164 File Offset: 0x0021A364
		// (set) Token: 0x060079D7 RID: 31191 RVA: 0x0021C1A0 File Offset: 0x0021A3A0
		public unsafe float CurrentLiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x0021C1E0 File Offset: 0x0021A3E0
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x0021C21C File Offset: 0x0021A41C
		public unsafe Color LiquidColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x0021C25C File Offset: 0x0021A45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233952, XrefRangeEnd = 233959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x0021C290 File Offset: 0x0021A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233959, XrefRangeEnd = 233977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x0021C2C4 File Offset: 0x0021A4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233977, XrefRangeEnd = 233992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x0021C2F8 File Offset: 0x0021A4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233992, XrefRangeEnd = 233993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x0021C32C File Offset: 0x0021A52C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234001, RefRangeEnd = 234005, XrefRangeStart = 233993, XrefRangeEnd = 234001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLighting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_UpdateLighting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x0021C360 File Offset: 0x0021A560
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 234040, RefRangeEnd = 234048, XrefRangeStart = 234005, XrefRangeEnd = 234040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidLevel(float level, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x0021C3AC File Offset: 0x0021A5AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234051, RefRangeEnd = 234053, XrefRangeStart = 234048, XrefRangeEnd = 234051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setColorVariable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateLigting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x0021C408 File Offset: 0x0021A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234053, XrefRangeEnd = 234054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x0003A06A File Offset: 0x0003826A
		public LiquidContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x0021C444 File Offset: 0x0021A644
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x0003A073 File Offset: 0x00038273
		public unsafe float _CurrentLiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x060079E5 RID: 31205 RVA: 0x0021C46C File Offset: 0x0021A66C
		// (set) Token: 0x060079E6 RID: 31206 RVA: 0x0003A08E File Offset: 0x0003828E
		public unsafe Color _LiquidColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr__LiquidColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x060079E7 RID: 31207 RVA: 0x0021C494 File Offset: 0x0021A694
		// (set) Token: 0x060079E8 RID: 31208 RVA: 0x0003A0A9 File Offset: 0x000382A9
		public unsafe float Viscosity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Viscosity)) = value;
			}
		}

		// Token: 0x170025AC RID: 9644
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x0021C4BC File Offset: 0x0021A6BC
		// (set) Token: 0x060079EA RID: 31210 RVA: 0x0003A0C4 File Offset: 0x000382C4
		public unsafe bool AdjustMurkiness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_AdjustMurkiness)) = value;
			}
		}

		// Token: 0x170025AD RID: 9645
		// (get) Token: 0x060079EB RID: 31211 RVA: 0x0021C4E4 File Offset: 0x0021A6E4
		// (set) Token: 0x060079EC RID: 31212 RVA: 0x0003A0DF File Offset: 0x000382DF
		public unsafe LiquidVolume LiquidVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolume>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_LiquidVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AE RID: 9646
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x0021C514 File Offset: 0x0021A714
		// (set) Token: 0x060079EE RID: 31214 RVA: 0x0003A0FE File Offset: 0x000382FE
		public unsafe LiquidVolumeCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidVolumeCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025AF RID: 9647
		// (get) Token: 0x060079EF RID: 31215 RVA: 0x0021C544 File Offset: 0x0021A744
		// (set) Token: 0x060079F0 RID: 31216 RVA: 0x0003A11D File Offset: 0x0003831D
		public unsafe Transform ColliderTransform_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B0 RID: 9648
		// (get) Token: 0x060079F1 RID: 31217 RVA: 0x0021C574 File Offset: 0x0021A774
		// (set) Token: 0x060079F2 RID: 31218 RVA: 0x0003A13C File Offset: 0x0003833C
		public unsafe Transform ColliderTransform_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_ColliderTransform_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B1 RID: 9649
		// (get) Token: 0x060079F3 RID: 31219 RVA: 0x0021C5A4 File Offset: 0x0021A7A4
		// (set) Token: 0x060079F4 RID: 31220 RVA: 0x0003A15B File Offset: 0x0003835B
		public unsafe float MaxLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_MaxLevel)) = value;
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x0021C5CC File Offset: 0x0021A7CC
		// (set) Token: 0x060079F6 RID: 31222 RVA: 0x0003A176 File Offset: 0x00038376
		public unsafe MeshRenderer liquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidContainer.NativeFieldInfoPtr_liquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005301 RID: 21249
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLiquidLevel_k__BackingField;

		// Token: 0x04005302 RID: 21250
		private static readonly IntPtr NativeFieldInfoPtr__LiquidColor_k__BackingField;

		// Token: 0x04005303 RID: 21251
		private static readonly IntPtr NativeFieldInfoPtr_Viscosity;

		// Token: 0x04005304 RID: 21252
		private static readonly IntPtr NativeFieldInfoPtr_AdjustMurkiness;

		// Token: 0x04005305 RID: 21253
		private static readonly IntPtr NativeFieldInfoPtr_LiquidVolume;

		// Token: 0x04005306 RID: 21254
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005307 RID: 21255
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Min;

		// Token: 0x04005308 RID: 21256
		private static readonly IntPtr NativeFieldInfoPtr_ColliderTransform_Max;

		// Token: 0x04005309 RID: 21257
		private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

		// Token: 0x0400530A RID: 21258
		private static readonly IntPtr NativeFieldInfoPtr_liquidMesh;

		// Token: 0x0400530B RID: 21259
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLiquidLevel_Public_get_Single_0;

		// Token: 0x0400530C RID: 21260
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLiquidLevel_Private_set_Void_Single_0;

		// Token: 0x0400530D RID: 21261
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidColor_Public_get_Color_0;

		// Token: 0x0400530E RID: 21262
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidColor_Private_set_Void_Color_0;

		// Token: 0x0400530F RID: 21263
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005310 RID: 21264
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005311 RID: 21265
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005312 RID: 21266
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005313 RID: 21267
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLighting_Private_Void_0;

		// Token: 0x04005314 RID: 21268
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Void_Single_Boolean_0;

		// Token: 0x04005315 RID: 21269
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidColor_Public_Void_Color_Boolean_Boolean_0;

		// Token: 0x04005316 RID: 21270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
