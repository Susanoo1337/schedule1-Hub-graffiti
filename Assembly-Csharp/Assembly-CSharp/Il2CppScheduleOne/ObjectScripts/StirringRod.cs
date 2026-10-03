using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A7 RID: 1447
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x0600869A RID: 34458 RVA: 0x0024B3EC File Offset: 0x002495EC
		// Note: this type is marked as 'beforefieldinit'.
		static StirringRod()
		{
			Il2CppClassPointerStore<StirringRod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "StirringRod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StirringRod>.NativeClassPtr);
			StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_STIR_RATE");
			StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_PIVOT_ANGLE");
			StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<Interactable>k__BackingField");
			StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<CurrentStirringSpeed>k__BackingField");
			StirringRod.NativeFieldInfoPtr_LerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "LerpSpeed");
			StirringRod.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Clickable");
			StirringRod.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "PlaneNormal");
			StirringRod.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Container");
			StirringRod.NativeFieldInfoPtr_RodPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "RodPivot");
			StirringRod.NativeFieldInfoPtr_StirSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "StirSound");
			StirringRod.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "clickOffset");
			StirringRod.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "isMoving");
			StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680619);
			StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680620);
			StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680621);
			StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680622);
			StirringRod.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680623);
			StirringRod.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680624);
			StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680625);
			StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680626);
			StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680627);
			StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680628);
			StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680629);
			StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680630);
			StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100680631);
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600869B RID: 34459 RVA: 0x0024B610 File Offset: 0x00249810
		// (set) Token: 0x0600869C RID: 34460 RVA: 0x0024B64C File Offset: 0x0024984C
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600869D RID: 34461 RVA: 0x0024B68C File Offset: 0x0024988C
		// (set) Token: 0x0600869E RID: 34462 RVA: 0x0024B6C8 File Offset: 0x002498C8
		public unsafe float CurrentStirringSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x0024B708 File Offset: 0x00249908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251960, XrefRangeEnd = 251977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x0024B73C File Offset: 0x0024993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251977, XrefRangeEnd = 251982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x0024B770 File Offset: 0x00249970
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x0024B7A4 File Offset: 0x002499A4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 251982, RefRangeEnd = 251996, XrefRangeStart = 251982, XrefRangeEnd = 251982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x0024B7E4 File Offset: 0x002499E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251996, XrefRangeEnd = 251999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x0024B824 File Offset: 0x00249A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252011, RefRangeEnd = 252012, XrefRangeStart = 251999, XrefRangeEnd = 252011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x0024B860 File Offset: 0x00249A60
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x0024B894 File Offset: 0x00249A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252017, RefRangeEnd = 252019, XrefRangeStart = 252012, XrefRangeEnd = 252017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x0024B8C8 File Offset: 0x00249AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252019, XrefRangeEnd = 252022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StirringRod() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StirringRod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x0003FEAB File Offset: 0x0003E0AB
		public StirringRod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x0024B904 File Offset: 0x00249B04
		// (set) Token: 0x060086AA RID: 34474 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
		public unsafe static float MAX_STIR_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&value));
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x0024B920 File Offset: 0x00249B20
		// (set) Token: 0x060086AC RID: 34476 RVA: 0x0003FEC2 File Offset: 0x0003E0C2
		public unsafe static float MAX_PIVOT_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x0024B93C File Offset: 0x00249B3C
		// (set) Token: 0x060086AE RID: 34478 RVA: 0x0003FED0 File Offset: 0x0003E0D0
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060086AF RID: 34479 RVA: 0x0024B964 File Offset: 0x00249B64
		// (set) Token: 0x060086B0 RID: 34480 RVA: 0x0003FEEB File Offset: 0x0003E0EB
		public unsafe float _CurrentStirringSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060086B1 RID: 34481 RVA: 0x0024B98C File Offset: 0x00249B8C
		// (set) Token: 0x060086B2 RID: 34482 RVA: 0x0003FF06 File Offset: 0x0003E106
		public unsafe float LerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed)) = value;
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x0024B9B4 File Offset: 0x00249BB4
		// (set) Token: 0x060086B4 RID: 34484 RVA: 0x0003FF21 File Offset: 0x0003E121
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x0024B9E4 File Offset: 0x00249BE4
		// (set) Token: 0x060086B6 RID: 34486 RVA: 0x0003FF40 File Offset: 0x0003E140
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x0024BA14 File Offset: 0x00249C14
		// (set) Token: 0x060086B8 RID: 34488 RVA: 0x0003FF5F File Offset: 0x0003E15F
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x0024BA44 File Offset: 0x00249C44
		// (set) Token: 0x060086BA RID: 34490 RVA: 0x0003FF7E File Offset: 0x0003E17E
		public unsafe Transform RodPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x0024BA74 File Offset: 0x00249C74
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x0003FF9D File Offset: 0x0003E19D
		public unsafe AudioSourceController StirSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x0024BAA4 File Offset: 0x00249CA4
		// (set) Token: 0x060086BE RID: 34494 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x060086BF RID: 34495 RVA: 0x0024BACC File Offset: 0x00249CCC
		// (set) Token: 0x060086C0 RID: 34496 RVA: 0x0003FFD7 File Offset: 0x0003E1D7
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x04005BF4 RID: 23540
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STIR_RATE;

		// Token: 0x04005BF5 RID: 23541
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PIVOT_ANGLE;

		// Token: 0x04005BF6 RID: 23542
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04005BF7 RID: 23543
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField;

		// Token: 0x04005BF8 RID: 23544
		private static readonly IntPtr NativeFieldInfoPtr_LerpSpeed;

		// Token: 0x04005BF9 RID: 23545
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04005BFA RID: 23546
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04005BFB RID: 23547
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005BFC RID: 23548
		private static readonly IntPtr NativeFieldInfoPtr_RodPivot;

		// Token: 0x04005BFD RID: 23549
		private static readonly IntPtr NativeFieldInfoPtr_StirSound;

		// Token: 0x04005BFE RID: 23550
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04005BFF RID: 23551
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04005C00 RID: 23552
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04005C01 RID: 23553
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04005C02 RID: 23554
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0;

		// Token: 0x04005C03 RID: 23555
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0;

		// Token: 0x04005C04 RID: 23556
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005C05 RID: 23557
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005C06 RID: 23558
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005C07 RID: 23559
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005C08 RID: 23560
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04005C09 RID: 23561
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04005C0A RID: 23562
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04005C0B RID: 23563
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005C0C RID: 23564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
