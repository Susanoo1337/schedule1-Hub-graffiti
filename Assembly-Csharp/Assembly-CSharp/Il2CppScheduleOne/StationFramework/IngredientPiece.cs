using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200053A RID: 1338
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x060079A5 RID: 31141 RVA: 0x0021B62C File Offset: 0x0021982C
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientPiece()
		{
			Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientPiece");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr);
			IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LIQUID_FRICTION");
			IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<CurrentDissolveAmount>k__BackingField");
			IngredientPiece.NativeFieldInfoPtr__CurrentLiquidContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<CurrentLiquidContainer>k__BackingField");
			IngredientPiece.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "ModelContainer");
			IngredientPiece.NativeFieldInfoPtr_DissolveParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DissolveParticles");
			IngredientPiece.NativeFieldInfoPtr_DetectLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DetectLiquid");
			IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DisableInteractionInLiquid");
			IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LiquidFrictionMultiplier");
			IngredientPiece.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "draggable");
			IngredientPiece.NativeFieldInfoPtr_defaultDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "defaultDrag");
			IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "dissolveParticleRoutine");
			IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678930);
			IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678931);
			IngredientPiece.NativeMethodInfoPtr_get_CurrentLiquidContainer_Public_get_LiquidContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678932);
			IngredientPiece.NativeMethodInfoPtr_set_CurrentLiquidContainer_Private_set_Void_LiquidContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678933);
			IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678934);
			IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678935);
			IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678936);
			IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678937);
			IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678938);
			IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678939);
			IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678940);
			IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678941);
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x0021B828 File Offset: 0x00219A28
		// (set) Token: 0x060079A7 RID: 31143 RVA: 0x0021B864 File Offset: 0x00219A64
		public unsafe float CurrentDissolveAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x060079A8 RID: 31144 RVA: 0x0021B8A4 File Offset: 0x00219AA4
		// (set) Token: 0x060079A9 RID: 31145 RVA: 0x0021B8E4 File Offset: 0x00219AE4
		public unsafe LiquidContainer CurrentLiquidContainer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_get_CurrentLiquidContainer_Public_get_LiquidContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_set_CurrentLiquidContainer_Private_set_Void_LiquidContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x0021B928 File Offset: 0x00219B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233879, XrefRangeEnd = 233886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079AB RID: 31147 RVA: 0x0021B95C File Offset: 0x00219B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233886, XrefRangeEnd = 233890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x0021B990 File Offset: 0x00219B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233890, XrefRangeEnd = 233891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079AD RID: 31149 RVA: 0x0021B9C4 File Offset: 0x00219BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233911, RefRangeEnd = 233912, XrefRangeStart = 233891, XrefRangeEnd = 233911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x0021B9F8 File Offset: 0x00219BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233912, XrefRangeEnd = 233928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x0021BA2C File Offset: 0x00219C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233943, RefRangeEnd = 233944, XrefRangeStart = 233928, XrefRangeEnd = 233943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DissolveAmount(float amount, bool showParticles = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x0021BA78 File Offset: 0x00219C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233944, XrefRangeEnd = 233945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientPiece() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079B1 RID: 31153 RVA: 0x0021BAB4 File Offset: 0x00219CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233945, XrefRangeEnd = 233950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x00039EEE File Offset: 0x000380EE
		public IngredientPiece(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x0021BAF4 File Offset: 0x00219CF4
		// (set) Token: 0x060079B4 RID: 31156 RVA: 0x00039EF7 File Offset: 0x000380F7
		public unsafe static float LIQUID_FRICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&value));
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x060079B5 RID: 31157 RVA: 0x0021BB10 File Offset: 0x00219D10
		// (set) Token: 0x060079B6 RID: 31158 RVA: 0x00039F05 File Offset: 0x00038105
		public unsafe float _CurrentDissolveAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x060079B7 RID: 31159 RVA: 0x0021BB38 File Offset: 0x00219D38
		// (set) Token: 0x060079B8 RID: 31160 RVA: 0x00039F20 File Offset: 0x00038120
		public unsafe LiquidContainer _CurrentLiquidContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentLiquidContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentLiquidContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x060079B9 RID: 31161 RVA: 0x0021BB68 File Offset: 0x00219D68
		// (set) Token: 0x060079BA RID: 31162 RVA: 0x00039F3F File Offset: 0x0003813F
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x060079BB RID: 31163 RVA: 0x0021BB98 File Offset: 0x00219D98
		// (set) Token: 0x060079BC RID: 31164 RVA: 0x00039F5E File Offset: 0x0003815E
		public unsafe ParticleSystem DissolveParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x060079BD RID: 31165 RVA: 0x0021BBC8 File Offset: 0x00219DC8
		// (set) Token: 0x060079BE RID: 31166 RVA: 0x00039F7D File Offset: 0x0003817D
		public unsafe bool DetectLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid)) = value;
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x060079BF RID: 31167 RVA: 0x0021BBF0 File Offset: 0x00219DF0
		// (set) Token: 0x060079C0 RID: 31168 RVA: 0x00039F98 File Offset: 0x00038198
		public unsafe bool DisableInteractionInLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid)) = value;
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x060079C1 RID: 31169 RVA: 0x0021BC18 File Offset: 0x00219E18
		// (set) Token: 0x060079C2 RID: 31170 RVA: 0x00039FB3 File Offset: 0x000381B3
		public unsafe float LiquidFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier)) = value;
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x060079C3 RID: 31171 RVA: 0x0021BC40 File Offset: 0x00219E40
		// (set) Token: 0x060079C4 RID: 31172 RVA: 0x00039FCE File Offset: 0x000381CE
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x0021BC70 File Offset: 0x00219E70
		// (set) Token: 0x060079C6 RID: 31174 RVA: 0x00039FED File Offset: 0x000381ED
		public unsafe float defaultDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag)) = value;
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x0021BC98 File Offset: 0x00219E98
		// (set) Token: 0x060079C8 RID: 31176 RVA: 0x0003A008 File Offset: 0x00038208
		public unsafe Coroutine dissolveParticleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052E2 RID: 21218
		private static readonly IntPtr NativeFieldInfoPtr_LIQUID_FRICTION;

		// Token: 0x040052E3 RID: 21219
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField;

		// Token: 0x040052E4 RID: 21220
		private static readonly IntPtr NativeFieldInfoPtr__CurrentLiquidContainer_k__BackingField;

		// Token: 0x040052E5 RID: 21221
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x040052E6 RID: 21222
		private static readonly IntPtr NativeFieldInfoPtr_DissolveParticles;

		// Token: 0x040052E7 RID: 21223
		private static readonly IntPtr NativeFieldInfoPtr_DetectLiquid;

		// Token: 0x040052E8 RID: 21224
		private static readonly IntPtr NativeFieldInfoPtr_DisableInteractionInLiquid;

		// Token: 0x040052E9 RID: 21225
		private static readonly IntPtr NativeFieldInfoPtr_LiquidFrictionMultiplier;

		// Token: 0x040052EA RID: 21226
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x040052EB RID: 21227
		private static readonly IntPtr NativeFieldInfoPtr_defaultDrag;

		// Token: 0x040052EC RID: 21228
		private static readonly IntPtr NativeFieldInfoPtr_dissolveParticleRoutine;

		// Token: 0x040052ED RID: 21229
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0;

		// Token: 0x040052EE RID: 21230
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0;

		// Token: 0x040052EF RID: 21231
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLiquidContainer_Public_get_LiquidContainer_0;

		// Token: 0x040052F0 RID: 21232
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLiquidContainer_Private_set_Void_LiquidContainer_0;

		// Token: 0x040052F1 RID: 21233
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040052F2 RID: 21234
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040052F3 RID: 21235
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040052F4 RID: 21236
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_0;

		// Token: 0x040052F5 RID: 21237
		private static readonly IntPtr NativeMethodInfoPtr_CheckLiquid_Private_Void_0;

		// Token: 0x040052F6 RID: 21238
		private static readonly IntPtr NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0;

		// Token: 0x040052F7 RID: 21239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040052F8 RID: 21240
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BB9 RID: 3001
		[ObfuscatedName("ScheduleOne.StationFramework.IngredientPiece+<<DissolveAmount>g__DissolveParticlesRoutine|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EB1E RID: 60190 RVA: 0x003913EC File Offset: 0x0038F5EC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<<DissolveAmount>g__DissolveParticlesRoutine|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678942);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678943);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678944);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678945);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678946);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678947);
			}

			// Token: 0x0600EB1F RID: 60191 RVA: 0x003914CC File Offset: 0x0038F6CC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB20 RID: 60192 RVA: 0x00391514 File Offset: 0x0038F714
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB21 RID: 60193 RVA: 0x00391548 File Offset: 0x0038F748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233869, XrefRangeEnd = 233874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004754 RID: 18260
			// (get) Token: 0x0600EB22 RID: 60194 RVA: 0x00391584 File Offset: 0x0038F784
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EB23 RID: 60195 RVA: 0x003915C4 File Offset: 0x0038F7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233874, XrefRangeEnd = 233879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004755 RID: 18261
			// (get) Token: 0x0600EB24 RID: 60196 RVA: 0x003915F8 File Offset: 0x0038F7F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EB25 RID: 60197 RVA: 0x0006EE9B File Offset: 0x0006D09B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004751 RID: 18257
			// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x00391638 File Offset: 0x0038F838
			// (set) Token: 0x0600EB27 RID: 60199 RVA: 0x0006EEA4 File Offset: 0x0006D0A4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004752 RID: 18258
			// (get) Token: 0x0600EB28 RID: 60200 RVA: 0x00391660 File Offset: 0x0038F860
			// (set) Token: 0x0600EB29 RID: 60201 RVA: 0x0006EEBF File Offset: 0x0006D0BF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004753 RID: 18259
			// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x00391690 File Offset: 0x0038F890
			// (set) Token: 0x0600EB2B RID: 60203 RVA: 0x0006EEDE File Offset: 0x0006D0DE
			public unsafe IngredientPiece __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientPiece>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F54 RID: 40788
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009F55 RID: 40789
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009F56 RID: 40790
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F57 RID: 40791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009F58 RID: 40792
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F59 RID: 40793
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009F5A RID: 40794
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009F5B RID: 40795
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F5C RID: 40796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
