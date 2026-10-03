using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200059F RID: 1439
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x060083D8 RID: 33752 RVA: 0x00240A10 File Offset: 0x0023EC10
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressHandle()
		{
			Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr);
			BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<Interactable>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "<TargetPosition>k__BackingField");
			BrickPressHandle.NativeFieldInfoPtr_lastClickPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "lastClickPosition");
			BrickPressHandle.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "MoveSpeed");
			BrickPressHandle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "Locked");
			BrickPressHandle.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "PlaneNormal");
			BrickPressHandle.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "RaisedTransform");
			BrickPressHandle.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "LoweredTransform");
			BrickPressHandle.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "HandleClickable");
			BrickPressHandle.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "ClickSound");
			BrickPressHandle.NativeFieldInfoPtr__handlePromptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "_handlePromptData");
			BrickPressHandle.NativeFieldInfoPtr__handlePromptAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "_handlePromptAnchor");
			BrickPressHandle.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "clickOffset");
			BrickPressHandle.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "isMoving");
			BrickPressHandle.NativeFieldInfoPtr__currentVerticalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, "_currentVerticalPos");
			BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680267);
			BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680268);
			BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680269);
			BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680270);
			BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680271);
			BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680272);
			BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680273);
			BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680274);
			BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680275);
			BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680276);
			BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680277);
			BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680278);
			BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680279);
			BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680280);
			BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680281);
			BrickPressHandle.NativeMethodInfoPtr_HasValidGamepadRotationInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680282);
			BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr, 100680283);
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x060083D9 RID: 33753 RVA: 0x00240CD4 File Offset: 0x0023EED4
		// (set) Token: 0x060083DA RID: 33754 RVA: 0x00240D10 File Offset: 0x0023EF10
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x060083DB RID: 33755 RVA: 0x00240D50 File Offset: 0x0023EF50
		// (set) Token: 0x060083DC RID: 33756 RVA: 0x00240D8C File Offset: 0x0023EF8C
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x060083DD RID: 33757 RVA: 0x00240DCC File Offset: 0x0023EFCC
		// (set) Token: 0x060083DE RID: 33758 RVA: 0x00240E08 File Offset: 0x0023F008
		public unsafe float TargetPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x00240E48 File Offset: 0x0023F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248471, XrefRangeEnd = 248488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x00240E7C File Offset: 0x0023F07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248488, XrefRangeEnd = 248506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x00240EB0 File Offset: 0x0023F0B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248515, RefRangeEnd = 248516, XrefRangeStart = 248506, XrefRangeEnd = 248515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x00240EE4 File Offset: 0x0023F0E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65014, RefRangeEnd = 65022, XrefRangeStart = 65014, XrefRangeEnd = 65022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x00240F24 File Offset: 0x0023F124
		[CallerCount(0)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x00240F64 File Offset: 0x0023F164
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248516, RefRangeEnd = 248519, XrefRangeStart = 248516, XrefRangeEnd = 248516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x00240FA4 File Offset: 0x0023F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248519, XrefRangeEnd = 248540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x00240FE4 File Offset: 0x0023F1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248540, XrefRangeEnd = 248562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x00241018 File Offset: 0x0023F218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248585, RefRangeEnd = 248586, XrefRangeStart = 248562, XrefRangeEnd = 248585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x00241054 File Offset: 0x0023F254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248586, XrefRangeEnd = 248591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasValidGamepadRotationInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr_HasValidGamepadRotationInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x00241090 File Offset: 0x0023F290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248591, XrefRangeEnd = 248594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressHandle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressHandle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x0003E97F File Offset: 0x0003CB7F
		public BrickPressHandle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x002410CC File Offset: 0x0023F2CC
		// (set) Token: 0x060083EC RID: 33772 RVA: 0x0003E988 File Offset: 0x0003CB88
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060083ED RID: 33773 RVA: 0x002410F4 File Offset: 0x0023F2F4
		// (set) Token: 0x060083EE RID: 33774 RVA: 0x0003E9A3 File Offset: 0x0003CBA3
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060083EF RID: 33775 RVA: 0x0024111C File Offset: 0x0023F31C
		// (set) Token: 0x060083F0 RID: 33776 RVA: 0x0003E9BE File Offset: 0x0003CBBE
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060083F1 RID: 33777 RVA: 0x00241144 File Offset: 0x0023F344
		// (set) Token: 0x060083F2 RID: 33778 RVA: 0x0003E9D9 File Offset: 0x0003CBD9
		public unsafe float lastClickPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_lastClickPosition)) = value;
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060083F3 RID: 33779 RVA: 0x0024116C File Offset: 0x0023F36C
		// (set) Token: 0x060083F4 RID: 33780 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x060083F5 RID: 33781 RVA: 0x00241194 File Offset: 0x0023F394
		// (set) Token: 0x060083F6 RID: 33782 RVA: 0x0003EA0F File Offset: 0x0003CC0F
		public unsafe bool Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_Locked)) = value;
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x060083F7 RID: 33783 RVA: 0x002411BC File Offset: 0x0023F3BC
		// (set) Token: 0x060083F8 RID: 33784 RVA: 0x0003EA2A File Offset: 0x0003CC2A
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x060083F9 RID: 33785 RVA: 0x002411EC File Offset: 0x0023F3EC
		// (set) Token: 0x060083FA RID: 33786 RVA: 0x0003EA49 File Offset: 0x0003CC49
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x060083FB RID: 33787 RVA: 0x0024121C File Offset: 0x0023F41C
		// (set) Token: 0x060083FC RID: 33788 RVA: 0x0003EA68 File Offset: 0x0003CC68
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x060083FD RID: 33789 RVA: 0x0024124C File Offset: 0x0023F44C
		// (set) Token: 0x060083FE RID: 33790 RVA: 0x0003EA87 File Offset: 0x0003CC87
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x060083FF RID: 33791 RVA: 0x0024127C File Offset: 0x0023F47C
		// (set) Token: 0x06008400 RID: 33792 RVA: 0x0003EAA6 File Offset: 0x0003CCA6
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x06008401 RID: 33793 RVA: 0x002412AC File Offset: 0x0023F4AC
		// (set) Token: 0x06008402 RID: 33794 RVA: 0x0003EAC5 File Offset: 0x0003CCC5
		public unsafe InputPromptsData _handlePromptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__handlePromptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__handlePromptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x06008403 RID: 33795 RVA: 0x002412DC File Offset: 0x0023F4DC
		// (set) Token: 0x06008404 RID: 33796 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
		public unsafe Transform _handlePromptAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__handlePromptAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__handlePromptAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x0024130C File Offset: 0x0023F50C
		// (set) Token: 0x06008406 RID: 33798 RVA: 0x0003EB03 File Offset: 0x0003CD03
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x06008407 RID: 33799 RVA: 0x00241334 File Offset: 0x0023F534
		// (set) Token: 0x06008408 RID: 33800 RVA: 0x0003EB1E File Offset: 0x0003CD1E
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x0024135C File Offset: 0x0023F55C
		// (set) Token: 0x0600840A RID: 33802 RVA: 0x0003EB39 File Offset: 0x0003CD39
		public unsafe float _currentVerticalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__currentVerticalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressHandle.NativeFieldInfoPtr__currentVerticalPos)) = value;
			}
		}

		// Token: 0x040059F6 RID: 23030
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040059F7 RID: 23031
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x040059F8 RID: 23032
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x040059F9 RID: 23033
		private static readonly IntPtr NativeFieldInfoPtr_lastClickPosition;

		// Token: 0x040059FA RID: 23034
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040059FB RID: 23035
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x040059FC RID: 23036
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040059FD RID: 23037
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x040059FE RID: 23038
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x040059FF RID: 23039
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04005A00 RID: 23040
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x04005A01 RID: 23041
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptData;

		// Token: 0x04005A02 RID: 23042
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptAnchor;

		// Token: 0x04005A03 RID: 23043
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04005A04 RID: 23044
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04005A05 RID: 23045
		private static readonly IntPtr NativeFieldInfoPtr__currentVerticalPos;

		// Token: 0x04005A06 RID: 23046
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04005A07 RID: 23047
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04005A08 RID: 23048
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x04005A09 RID: 23049
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x04005A0A RID: 23050
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x04005A0B RID: 23051
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x04005A0C RID: 23052
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005A0D RID: 23053
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005A0E RID: 23054
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04005A0F RID: 23055
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x04005A10 RID: 23056
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04005A11 RID: 23057
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005A12 RID: 23058
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04005A13 RID: 23059
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04005A14 RID: 23060
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04005A15 RID: 23061
		private static readonly IntPtr NativeMethodInfoPtr_HasValidGamepadRotationInput_Private_Boolean_0;

		// Token: 0x04005A16 RID: 23062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
