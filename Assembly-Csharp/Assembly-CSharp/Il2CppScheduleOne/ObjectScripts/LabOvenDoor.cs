using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005AC RID: 1452
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x060088F4 RID: 35060 RVA: 0x00254DC8 File Offset: 0x00252FC8
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenDoor()
		{
			Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr);
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MAX");
			LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HIT_OFFSET_MIN");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_CLOSED");
			LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DOOR_ANGLE_OPEN");
			LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<Interactable>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<TargetPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "<ActualPosition>k__BackingField");
			LabOvenDoor.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HandleClickable");
			LabOvenDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "Door");
			LabOvenDoor.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "PlaneNormal");
			LabOvenDoor.NativeFieldInfoPtr_HitMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "HitMapCurve");
			LabOvenDoor.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "OpenSound");
			LabOvenDoor.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "CloseSound");
			LabOvenDoor.NativeFieldInfoPtr_ShutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "ShutSound");
			LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "DoorMoveSpeed");
			LabOvenDoor.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "clickOffset");
			LabOvenDoor.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, "isMoving");
			LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680959);
			LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680960);
			LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680961);
			LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680962);
			LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680963);
			LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680964);
			LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680965);
			LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680966);
			LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680967);
			LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680968);
			LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680969);
			LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680970);
			LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680971);
			LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680972);
			LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr, 100680973);
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x060088F5 RID: 35061 RVA: 0x00255078 File Offset: 0x00253278
		// (set) Token: 0x060088F6 RID: 35062 RVA: 0x002550B4 File Offset: 0x002532B4
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x002550F4 File Offset: 0x002532F4
		// (set) Token: 0x060088F8 RID: 35064 RVA: 0x00255130 File Offset: 0x00253330
		public unsafe float TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x060088F9 RID: 35065 RVA: 0x00255170 File Offset: 0x00253370
		// (set) Token: 0x060088FA RID: 35066 RVA: 0x002551AC File Offset: 0x002533AC
		public unsafe float ActualPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x002551EC File Offset: 0x002533EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255379, XrefRangeEnd = 255397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x00255220 File Offset: 0x00253420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255397, XrefRangeEnd = 255411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x00255254 File Offset: 0x00253454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255411, XrefRangeEnd = 255419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x00255288 File Offset: 0x00253488
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 251982, RefRangeEnd = 251996, XrefRangeStart = 251982, XrefRangeEnd = 251996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x002552C8 File Offset: 0x002534C8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 255421, RefRangeEnd = 255438, XrefRangeStart = 255419, XrefRangeEnd = 255421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x00255308 File Offset: 0x00253508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255438, XrefRangeEnd = 255441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x00255348 File Offset: 0x00253548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255453, RefRangeEnd = 255455, XrefRangeStart = 255441, XrefRangeEnd = 255453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x00255384 File Offset: 0x00253584
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x002553B8 File Offset: 0x002535B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255455, XrefRangeEnd = 255458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		public LabOvenDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A6B RID: 10859
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x002553F4 File Offset: 0x002535F4
		// (set) Token: 0x06008906 RID: 35078 RVA: 0x00040EB1 File Offset: 0x0003F0B1
		public unsafe static float HIT_OFFSET_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002A6C RID: 10860
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x00255410 File Offset: 0x00253610
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x00040EBF File Offset: 0x0003F0BF
		public unsafe static float HIT_OFFSET_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_HIT_OFFSET_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002A6D RID: 10861
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x0025542C File Offset: 0x0025362C
		// (set) Token: 0x0600890A RID: 35082 RVA: 0x00040ECD File Offset: 0x0003F0CD
		public unsafe static float DOOR_ANGLE_CLOSED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_CLOSED, (void*)(&value));
			}
		}

		// Token: 0x17002A6E RID: 10862
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x00255448 File Offset: 0x00253648
		// (set) Token: 0x0600890C RID: 35084 RVA: 0x00040EDB File Offset: 0x0003F0DB
		public unsafe static float DOOR_ANGLE_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenDoor.NativeFieldInfoPtr_DOOR_ANGLE_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17002A6F RID: 10863
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x00255464 File Offset: 0x00253664
		// (set) Token: 0x0600890E RID: 35086 RVA: 0x00040EE9 File Offset: 0x0003F0E9
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A70 RID: 10864
		// (get) Token: 0x0600890F RID: 35087 RVA: 0x0025548C File Offset: 0x0025368C
		// (set) Token: 0x06008910 RID: 35088 RVA: 0x00040F04 File Offset: 0x0003F104
		public unsafe float _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A71 RID: 10865
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x002554B4 File Offset: 0x002536B4
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x00040F1F File Offset: 0x0003F11F
		public unsafe float _ActualPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr__ActualPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x002554DC File Offset: 0x002536DC
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x00040F3A File Offset: 0x0003F13A
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x06008915 RID: 35093 RVA: 0x0025550C File Offset: 0x0025370C
		// (set) Token: 0x06008916 RID: 35094 RVA: 0x00040F59 File Offset: 0x0003F159
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x06008917 RID: 35095 RVA: 0x0025553C File Offset: 0x0025373C
		// (set) Token: 0x06008918 RID: 35096 RVA: 0x00040F78 File Offset: 0x0003F178
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x06008919 RID: 35097 RVA: 0x0025556C File Offset: 0x0025376C
		// (set) Token: 0x0600891A RID: 35098 RVA: 0x00040F97 File Offset: 0x0003F197
		public unsafe AnimationCurve HitMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_HitMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x0025559C File Offset: 0x0025379C
		// (set) Token: 0x0600891C RID: 35100 RVA: 0x00040FB6 File Offset: 0x0003F1B6
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x0600891D RID: 35101 RVA: 0x002555CC File Offset: 0x002537CC
		// (set) Token: 0x0600891E RID: 35102 RVA: 0x00040FD5 File Offset: 0x0003F1D5
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A78 RID: 10872
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x002555FC File Offset: 0x002537FC
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x00040FF4 File Offset: 0x0003F1F4
		public unsafe AudioSourceController ShutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_ShutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A79 RID: 10873
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x0025562C File Offset: 0x0025382C
		// (set) Token: 0x06008922 RID: 35106 RVA: 0x00041013 File Offset: 0x0003F213
		public unsafe float DoorMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_DoorMoveSpeed)) = value;
			}
		}

		// Token: 0x17002A7A RID: 10874
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x00255654 File Offset: 0x00253854
		// (set) Token: 0x06008924 RID: 35108 RVA: 0x0004102E File Offset: 0x0003F22E
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x0025567C File Offset: 0x0025387C
		// (set) Token: 0x06008926 RID: 35110 RVA: 0x00041049 File Offset: 0x0003F249
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenDoor.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x04005DB9 RID: 23993
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MAX;

		// Token: 0x04005DBA RID: 23994
		private static readonly IntPtr NativeFieldInfoPtr_HIT_OFFSET_MIN;

		// Token: 0x04005DBB RID: 23995
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_CLOSED;

		// Token: 0x04005DBC RID: 23996
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_ANGLE_OPEN;

		// Token: 0x04005DBD RID: 23997
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04005DBE RID: 23998
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x04005DBF RID: 23999
		private static readonly IntPtr NativeFieldInfoPtr__ActualPosition_k__BackingField;

		// Token: 0x04005DC0 RID: 24000
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04005DC1 RID: 24001
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04005DC2 RID: 24002
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x04005DC3 RID: 24003
		private static readonly IntPtr NativeFieldInfoPtr_HitMapCurve;

		// Token: 0x04005DC4 RID: 24004
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04005DC5 RID: 24005
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04005DC6 RID: 24006
		private static readonly IntPtr NativeFieldInfoPtr_ShutSound;

		// Token: 0x04005DC7 RID: 24007
		private static readonly IntPtr NativeFieldInfoPtr_DoorMoveSpeed;

		// Token: 0x04005DC8 RID: 24008
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x04005DC9 RID: 24009
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x04005DCA RID: 24010
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04005DCB RID: 24011
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04005DCC RID: 24012
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Single_0;

		// Token: 0x04005DCD RID: 24013
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Single_0;

		// Token: 0x04005DCE RID: 24014
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualPosition_Public_get_Single_0;

		// Token: 0x04005DCF RID: 24015
		private static readonly IntPtr NativeMethodInfoPtr_set_ActualPosition_Private_set_Void_Single_0;

		// Token: 0x04005DD0 RID: 24016
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005DD1 RID: 24017
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005DD2 RID: 24018
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04005DD3 RID: 24019
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005DD4 RID: 24020
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x04005DD5 RID: 24021
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04005DD6 RID: 24022
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04005DD7 RID: 24023
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04005DD8 RID: 24024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
