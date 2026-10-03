using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000542 RID: 1346
	public class PourableModule : ItemModule
	{
		// Token: 0x06007AEC RID: 31468 RVA: 0x0022068C File Offset: 0x0021E88C
		// Note: this type is marked as 'beforefieldinit'.
		static PourableModule()
		{
			Il2CppClassPointerStore<PourableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableModule>.NativeClassPtr);
			PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<IsPouring>k__BackingField");
			PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<LiquidLevel>k__BackingField");
			PourableModule.NativeFieldInfoPtr_LiquidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidType");
			PourableModule.NativeFieldInfoPtr_PourRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourRate");
			PourableModule.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "AngleFromUpToPour");
			PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "OnlyEmptyOverFillable");
			PourableModule.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidCapacity_L");
			PourableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidColor");
			PourableModule.NativeFieldInfoPtr_DefaultLiquid_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DefaultLiquid_L");
			PourableModule.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticles");
			PourableModule.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourPoint");
			PourableModule.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidContainer");
			PourableModule.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "Draggable");
			PourableModule.NativeFieldInfoPtr_DraggableConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DraggableConstraint");
			PourableModule.NativeFieldInfoPtr_PourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourSound");
			PourableModule.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticlesColor");
			PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMinMultiplier");
			PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMaxMultiplier");
			PourableModule.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMinSizes");
			PourableModule.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMaxSizes");
			PourableModule.NativeFieldInfoPtr_activeFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "activeFillable");
			PourableModule.NativeFieldInfoPtr_timeSinceFillableHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "timeSinceFillableHit");
			PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679110);
			PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679111);
			PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679112);
			PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679113);
			PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679114);
			PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679115);
			PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679116);
			PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679117);
			PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679118);
			PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679119);
			PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679120);
			PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679121);
			PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679122);
			PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679123);
			PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679124);
			PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679125);
			PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679126);
			PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679127);
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06007AED RID: 31469 RVA: 0x002209F0 File Offset: 0x0021EBF0
		// (set) Token: 0x06007AEE RID: 31470 RVA: 0x00220A2C File Offset: 0x0021EC2C
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x00220A6C File Offset: 0x0021EC6C
		// (set) Token: 0x06007AF0 RID: 31472 RVA: 0x00220AA8 File Offset: 0x0021ECA8
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06007AF1 RID: 31473 RVA: 0x00220AE8 File Offset: 0x0021ECE8
		// (set) Token: 0x06007AF2 RID: 31474 RVA: 0x00220B24 File Offset: 0x0021ED24
		public unsafe float LiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44937, RefRangeEnd = 44940, XrefRangeStart = 44937, XrefRangeEnd = 44940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x00220B64 File Offset: 0x0021ED64
		public unsafe float NormalizedLiquidLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 235218, RefRangeEnd = 235223, XrefRangeStart = 235218, XrefRangeEnd = 235218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x00220BA0 File Offset: 0x0021EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235223, XrefRangeEnd = 235263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x00220BDC File Offset: 0x0021EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235263, XrefRangeEnd = 235274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x00220C2C File Offset: 0x0021EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235274, XrefRangeEnd = 235282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x00220C68 File Offset: 0x0021EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235282, XrefRangeEnd = 235308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x00220CA4 File Offset: 0x0021EEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235308, XrefRangeEnd = 235314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePourSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x00220CD8 File Offset: 0x0021EED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235314, XrefRangeEnd = 235320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeLiquidLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x00220D24 File Offset: 0x0021EF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235320, XrefRangeEnd = 235325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLiquidLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x00220D70 File Offset: 0x0021EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235325, XrefRangeEnd = 235343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x00220DBC File Offset: 0x0021EFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235343, XrefRangeEnd = 235352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x00220E00 File Offset: 0x0021F000
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x00220E48 File Offset: 0x0021F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235352, XrefRangeEnd = 235357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x0003A7AC File Offset: 0x000389AC
		public PourableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06007B00 RID: 31488 RVA: 0x00220E84 File Offset: 0x0021F084
		// (set) Token: 0x06007B01 RID: 31489 RVA: 0x0003A7B5 File Offset: 0x000389B5
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06007B02 RID: 31490 RVA: 0x00220EAC File Offset: 0x0021F0AC
		// (set) Token: 0x06007B03 RID: 31491 RVA: 0x0003A7D0 File Offset: 0x000389D0
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x00220ED4 File Offset: 0x0021F0D4
		// (set) Token: 0x06007B05 RID: 31493 RVA: 0x0003A7EB File Offset: 0x000389EB
		public unsafe float _LiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x00220EFC File Offset: 0x0021F0FC
		// (set) Token: 0x06007B07 RID: 31495 RVA: 0x0003A806 File Offset: 0x00038A06
		public unsafe string LiquidType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700260B RID: 9739
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x00220F24 File Offset: 0x0021F124
		// (set) Token: 0x06007B09 RID: 31497 RVA: 0x0003A825 File Offset: 0x00038A25
		public unsafe float PourRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate)) = value;
			}
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x00220F4C File Offset: 0x0021F14C
		// (set) Token: 0x06007B0B RID: 31499 RVA: 0x0003A840 File Offset: 0x00038A40
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x1700260D RID: 9741
		// (get) Token: 0x06007B0C RID: 31500 RVA: 0x00220F74 File Offset: 0x0021F174
		// (set) Token: 0x06007B0D RID: 31501 RVA: 0x0003A85B File Offset: 0x00038A5B
		public unsafe bool OnlyEmptyOverFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable)) = value;
			}
		}

		// Token: 0x1700260E RID: 9742
		// (get) Token: 0x06007B0E RID: 31502 RVA: 0x00220F9C File Offset: 0x0021F19C
		// (set) Token: 0x06007B0F RID: 31503 RVA: 0x0003A876 File Offset: 0x00038A76
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x00220FC4 File Offset: 0x0021F1C4
		// (set) Token: 0x06007B11 RID: 31505 RVA: 0x0003A891 File Offset: 0x00038A91
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x00220FEC File Offset: 0x0021F1EC
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x0003A8AC File Offset: 0x00038AAC
		public unsafe float DefaultLiquid_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L)) = value;
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x00221014 File Offset: 0x0021F214
		// (set) Token: 0x06007B15 RID: 31509 RVA: 0x0003A8C7 File Offset: 0x00038AC7
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06007B16 RID: 31510 RVA: 0x00221044 File Offset: 0x0021F244
		// (set) Token: 0x06007B17 RID: 31511 RVA: 0x0003A8E6 File Offset: 0x00038AE6
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x00221074 File Offset: 0x0021F274
		// (set) Token: 0x06007B19 RID: 31513 RVA: 0x0003A905 File Offset: 0x00038B05
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x002210A4 File Offset: 0x0021F2A4
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x0003A924 File Offset: 0x00038B24
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x002210D4 File Offset: 0x0021F2D4
		// (set) Token: 0x06007B1D RID: 31517 RVA: 0x0003A943 File Offset: 0x00038B43
		public unsafe DraggableConstraint DraggableConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x00221104 File Offset: 0x0021F304
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x0003A962 File Offset: 0x00038B62
		public unsafe AudioSourceController PourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x00221134 File Offset: 0x0021F334
		// (set) Token: 0x06007B21 RID: 31521 RVA: 0x0003A981 File Offset: 0x00038B81
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x0022115C File Offset: 0x0021F35C
		// (set) Token: 0x06007B23 RID: 31523 RVA: 0x0003A99C File Offset: 0x00038B9C
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x00221184 File Offset: 0x0021F384
		// (set) Token: 0x06007B25 RID: 31525 RVA: 0x0003A9B7 File Offset: 0x00038BB7
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x002211AC File Offset: 0x0021F3AC
		// (set) Token: 0x06007B27 RID: 31527 RVA: 0x0003A9D2 File Offset: 0x00038BD2
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x002211DC File Offset: 0x0021F3DC
		// (set) Token: 0x06007B29 RID: 31529 RVA: 0x0003A9F1 File Offset: 0x00038BF1
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06007B2A RID: 31530 RVA: 0x0022120C File Offset: 0x0021F40C
		// (set) Token: 0x06007B2B RID: 31531 RVA: 0x0003AA10 File Offset: 0x00038C10
		public unsafe Fillable activeFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x0022123C File Offset: 0x0021F43C
		// (set) Token: 0x06007B2D RID: 31533 RVA: 0x0003AA2F File Offset: 0x00038C2F
		public unsafe float timeSinceFillableHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit)) = value;
			}
		}

		// Token: 0x040053D0 RID: 21456
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x040053D1 RID: 21457
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x040053D2 RID: 21458
		private static readonly IntPtr NativeFieldInfoPtr__LiquidLevel_k__BackingField;

		// Token: 0x040053D3 RID: 21459
		private static readonly IntPtr NativeFieldInfoPtr_LiquidType;

		// Token: 0x040053D4 RID: 21460
		private static readonly IntPtr NativeFieldInfoPtr_PourRate;

		// Token: 0x040053D5 RID: 21461
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x040053D6 RID: 21462
		private static readonly IntPtr NativeFieldInfoPtr_OnlyEmptyOverFillable;

		// Token: 0x040053D7 RID: 21463
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x040053D8 RID: 21464
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040053D9 RID: 21465
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLiquid_L;

		// Token: 0x040053DA RID: 21466
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x040053DB RID: 21467
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x040053DC RID: 21468
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040053DD RID: 21469
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040053DE RID: 21470
		private static readonly IntPtr NativeFieldInfoPtr_DraggableConstraint;

		// Token: 0x040053DF RID: 21471
		private static readonly IntPtr NativeFieldInfoPtr_PourSound;

		// Token: 0x040053E0 RID: 21472
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x040053E1 RID: 21473
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x040053E2 RID: 21474
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x040053E3 RID: 21475
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x040053E4 RID: 21476
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x040053E5 RID: 21477
		private static readonly IntPtr NativeFieldInfoPtr_activeFillable;

		// Token: 0x040053E6 RID: 21478
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceFillableHit;

		// Token: 0x040053E7 RID: 21479
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x040053E8 RID: 21480
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x040053E9 RID: 21481
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x040053EA RID: 21482
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x040053EB RID: 21483
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0;

		// Token: 0x040053EC RID: 21484
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0;

		// Token: 0x040053ED RID: 21485
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0;

		// Token: 0x040053EE RID: 21486
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040053EF RID: 21487
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x040053F0 RID: 21488
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040053F1 RID: 21489
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x040053F2 RID: 21490
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePourSound_Private_Void_0;

		// Token: 0x040053F3 RID: 21491
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x040053F4 RID: 21492
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x040053F5 RID: 21493
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x040053F6 RID: 21494
		private static readonly IntPtr NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0;

		// Token: 0x040053F7 RID: 21495
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x040053F8 RID: 21496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
