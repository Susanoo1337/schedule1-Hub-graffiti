using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A6 RID: 1446
	public class LabStand : MonoBehaviour
	{
		// Token: 0x06008666 RID: 34406 RVA: 0x0024AAD4 File Offset: 0x00248CD4
		// Note: this type is marked as 'beforefieldinit'.
		static LabStand()
		{
			Il2CppClassPointerStore<LabStand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabStand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabStand>.NativeClassPtr);
			LabStand.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<Interactable>k__BackingField");
			LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			LabStand.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "MoveSpeed");
			LabStand.NativeFieldInfoPtr_FunnelEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelEnabled");
			LabStand.NativeFieldInfoPtr_FunnelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelThreshold");
			LabStand.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Anim");
			LabStand.NativeFieldInfoPtr_GripTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "GripTransform");
			LabStand.NativeFieldInfoPtr_SpinnyThingy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "SpinnyThingy");
			LabStand.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaisedTransform");
			LabStand.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LoweredTransform");
			LabStand.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "PlaneNormal");
			LabStand.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "HandleClickable");
			LabStand.NativeFieldInfoPtr_Funnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Funnel");
			LabStand.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Highlight");
			LabStand.NativeFieldInfoPtr_LowerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LowerSound");
			LabStand.NativeFieldInfoPtr_RaiseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaiseSound");
			LabStand.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "clickOffset");
			LabStand.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "isMoving");
			LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680605);
			LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680606);
			LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680607);
			LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680608);
			LabStand.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680609);
			LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680610);
			LabStand.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680611);
			LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680612);
			LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680613);
			LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680614);
			LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680615);
			LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680616);
			LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680617);
			LabStand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100680618);
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x0024AD84 File Offset: 0x00248F84
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x0024ADC0 File Offset: 0x00248FC0
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x0024AE00 File Offset: 0x00249000
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x0024AE3C File Offset: 0x0024903C
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x0024AE7C File Offset: 0x0024907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251861, XrefRangeEnd = 251881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x0024AEB0 File Offset: 0x002490B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251881, XrefRangeEnd = 251895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600866D RID: 34413 RVA: 0x0024AEE4 File Offset: 0x002490E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251922, RefRangeEnd = 251923, XrefRangeStart = 251895, XrefRangeEnd = 251922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x0024AF18 File Offset: 0x00249118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251923, XrefRangeEnd = 251931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x0024AF58 File Offset: 0x00249158
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x0024AF98 File Offset: 0x00249198
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251934, RefRangeEnd = 251940, XrefRangeStart = 251931, XrefRangeEnd = 251934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x0024AFD8 File Offset: 0x002491D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251940, XrefRangeEnd = 251943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x0024B018 File Offset: 0x00249218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251955, RefRangeEnd = 251957, XrefRangeStart = 251943, XrefRangeEnd = 251955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x0024B054 File Offset: 0x00249254
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x0024B088 File Offset: 0x00249288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251957, XrefRangeEnd = 251960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabStand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabStand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x0003FC90 File Offset: 0x0003DE90
		public LabStand(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06008676 RID: 34422 RVA: 0x0024B0C4 File Offset: 0x002492C4
		// (set) Token: 0x06008677 RID: 34423 RVA: 0x0003FC99 File Offset: 0x0003DE99
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x06008678 RID: 34424 RVA: 0x0024B0EC File Offset: 0x002492EC
		// (set) Token: 0x06008679 RID: 34425 RVA: 0x0003FCB4 File Offset: 0x0003DEB4
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600867A RID: 34426 RVA: 0x0024B114 File Offset: 0x00249314
		// (set) Token: 0x0600867B RID: 34427 RVA: 0x0003FCCF File Offset: 0x0003DECF
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x0024B13C File Offset: 0x0024933C
		// (set) Token: 0x0600867D RID: 34429 RVA: 0x0003FCEA File Offset: 0x0003DEEA
		public unsafe bool FunnelEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled)) = value;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600867E RID: 34430 RVA: 0x0024B164 File Offset: 0x00249364
		// (set) Token: 0x0600867F RID: 34431 RVA: 0x0003FD05 File Offset: 0x0003DF05
		public unsafe float FunnelThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold)) = value;
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x0024B18C File Offset: 0x0024938C
		// (set) Token: 0x06008681 RID: 34433 RVA: 0x0003FD20 File Offset: 0x0003DF20
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x06008682 RID: 34434 RVA: 0x0024B1BC File Offset: 0x002493BC
		// (set) Token: 0x06008683 RID: 34435 RVA: 0x0003FD3F File Offset: 0x0003DF3F
		public unsafe Transform GripTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x06008684 RID: 34436 RVA: 0x0024B1EC File Offset: 0x002493EC
		// (set) Token: 0x06008685 RID: 34437 RVA: 0x0003FD5E File Offset: 0x0003DF5E
		public unsafe Transform SpinnyThingy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x06008686 RID: 34438 RVA: 0x0024B21C File Offset: 0x0024941C
		// (set) Token: 0x06008687 RID: 34439 RVA: 0x0003FD7D File Offset: 0x0003DF7D
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x0024B24C File Offset: 0x0024944C
		// (set) Token: 0x06008689 RID: 34441 RVA: 0x0003FD9C File Offset: 0x0003DF9C
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0600868A RID: 34442 RVA: 0x0024B27C File Offset: 0x0024947C
		// (set) Token: 0x0600868B RID: 34443 RVA: 0x0003FDBB File Offset: 0x0003DFBB
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600868C RID: 34444 RVA: 0x0024B2AC File Offset: 0x002494AC
		// (set) Token: 0x0600868D RID: 34445 RVA: 0x0003FDDA File Offset: 0x0003DFDA
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600868E RID: 34446 RVA: 0x0024B2DC File Offset: 0x002494DC
		// (set) Token: 0x0600868F RID: 34447 RVA: 0x0003FDF9 File Offset: 0x0003DFF9
		public unsafe Transform Funnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x06008690 RID: 34448 RVA: 0x0024B30C File Offset: 0x0024950C
		// (set) Token: 0x06008691 RID: 34449 RVA: 0x0003FE18 File Offset: 0x0003E018
		public unsafe GameObject Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x06008692 RID: 34450 RVA: 0x0024B33C File Offset: 0x0024953C
		// (set) Token: 0x06008693 RID: 34451 RVA: 0x0003FE37 File Offset: 0x0003E037
		public unsafe AudioSourceController LowerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x06008694 RID: 34452 RVA: 0x0024B36C File Offset: 0x0024956C
		// (set) Token: 0x06008695 RID: 34453 RVA: 0x0003FE56 File Offset: 0x0003E056
		public unsafe AudioSourceController RaiseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x06008696 RID: 34454 RVA: 0x0024B39C File Offset: 0x0024959C
		// (set) Token: 0x06008697 RID: 34455 RVA: 0x0003FE75 File Offset: 0x0003E075
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x06008698 RID: 34456 RVA: 0x0024B3C4 File Offset: 0x002495C4
		// (set) Token: 0x06008699 RID: 34457 RVA: 0x0003FE90 File Offset: 0x0003E090
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x04005BD4 RID: 23508
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04005BD5 RID: 23509
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x04005BD6 RID: 23510
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x04005BD7 RID: 23511
		private static readonly IntPtr NativeFieldInfoPtr_FunnelEnabled;

		// Token: 0x04005BD8 RID: 23512
		private static readonly IntPtr NativeFieldInfoPtr_FunnelThreshold;

		// Token: 0x04005BD9 RID: 23513
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005BDA RID: 23514
		private static readonly IntPtr NativeFieldInfoPtr_GripTransform;

		// Token: 0x04005BDB RID: 23515
		private static readonly IntPtr NativeFieldInfoPtr_SpinnyThingy;

		// Token: 0x04005BDC RID: 23516
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x04005BDD RID: 23517
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x04005BDE RID: 23518
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04005BDF RID: 23519
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04005BE0 RID: 23520
		private static readonly IntPtr NativeFieldInfoPtr_Funnel;

		// Token: 0x04005BE1 RID: 23521
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x04005BE2 RID: 23522
		private static readonly IntPtr NativeFieldInfoPtr_LowerSound;

		// Token: 0x04005BE3 RID: 23523
		private static readonly IntPtr NativeFieldInfoPtr_RaiseSound;

		// Token: 0x04005BE4 RID: 23524
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04005BE5 RID: 23525
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04005BE6 RID: 23526
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04005BE7 RID: 23527
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04005BE8 RID: 23528
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x04005BE9 RID: 23529
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x04005BEA RID: 23530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005BEB RID: 23531
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005BEC RID: 23532
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04005BED RID: 23533
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x04005BEE RID: 23534
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04005BEF RID: 23535
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005BF0 RID: 23536
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04005BF1 RID: 23537
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04005BF2 RID: 23538
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04005BF3 RID: 23539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
