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
	// Token: 0x020005A3 RID: 1443
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x0600852E RID: 34094 RVA: 0x00245BDC File Offset: 0x00243DDC
		// Note: this type is marked as 'beforefieldinit'.
		static BunsenBurner()
		{
			Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BunsenBurner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr);
			BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<Interactable>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<IsDialHeld>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentDialValue>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentHeat>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr_LockDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LockDial");
			BunsenBurner.NativeFieldInfoPtr_FlameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameColor");
			BunsenBurner.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LightIntensity");
			BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleRotationSpeed");
			BunsenBurner.NativeFieldInfoPtr_FlamePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlamePitch");
			BunsenBurner.NativeFieldInfoPtr_Flame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Flame");
			BunsenBurner.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Light");
			BunsenBurner.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle");
			BunsenBurner.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleClickable");
			BunsenBurner.NativeFieldInfoPtr_Handle_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Min");
			BunsenBurner.NativeFieldInfoPtr_Handle_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Max");
			BunsenBurner.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Highlight");
			BunsenBurner.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Anim");
			BunsenBurner.NativeFieldInfoPtr_FlameSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameSound");
			BunsenBurner.NativeFieldInfoPtr__handlePromptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "_handlePromptData");
			BunsenBurner.NativeFieldInfoPtr__handlePromptAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "_handlePromptAnchor");
			BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680436);
			BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680437);
			BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680438);
			BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680439);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680440);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680441);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680442);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680443);
			BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680444);
			BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680445);
			BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680446);
			BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680447);
			BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680448);
			BunsenBurner.NativeMethodInfoPtr_GetDialValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680449);
			BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680450);
			BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680451);
			BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100680452);
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600852F RID: 34095 RVA: 0x00245EF0 File Offset: 0x002440F0
		// (set) Token: 0x06008530 RID: 34096 RVA: 0x00245F2C File Offset: 0x0024412C
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x06008531 RID: 34097 RVA: 0x00245F6C File Offset: 0x0024416C
		// (set) Token: 0x06008532 RID: 34098 RVA: 0x00245FA8 File Offset: 0x002441A8
		public unsafe bool IsDialHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x00245FE8 File Offset: 0x002441E8
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x00246024 File Offset: 0x00244224
		public unsafe float CurrentDialValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x00246064 File Offset: 0x00244264
		// (set) Token: 0x06008536 RID: 34102 RVA: 0x002460A0 File Offset: 0x002442A0
		public unsafe float CurrentHeat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008537 RID: 34103 RVA: 0x002460E0 File Offset: 0x002442E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250159, XrefRangeEnd = 250179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008538 RID: 34104 RVA: 0x00246114 File Offset: 0x00244314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250179, XrefRangeEnd = 250208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008539 RID: 34105 RVA: 0x00246148 File Offset: 0x00244348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250223, RefRangeEnd = 250224, XrefRangeStart = 250208, XrefRangeEnd = 250223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600853A RID: 34106 RVA: 0x0024617C File Offset: 0x0024437C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250229, RefRangeEnd = 250233, XrefRangeStart = 250224, XrefRangeEnd = 250229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDialPosition(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600853B RID: 34107 RVA: 0x002461BC File Offset: 0x002443BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250236, RefRangeEnd = 250239, XrefRangeStart = 250233, XrefRangeEnd = 250236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600853C RID: 34108 RVA: 0x002461FC File Offset: 0x002443FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250239, XrefRangeEnd = 250249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDialValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_GetDialValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600853D RID: 34109 RVA: 0x00246238 File Offset: 0x00244438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250249, XrefRangeEnd = 250269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600853E RID: 34110 RVA: 0x00246278 File Offset: 0x00244478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250269, XrefRangeEnd = 250291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600853F RID: 34111 RVA: 0x002462AC File Offset: 0x002444AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250291, XrefRangeEnd = 250292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunsenBurner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008540 RID: 34112 RVA: 0x0003F3F8 File Offset: 0x0003D5F8
		public BunsenBurner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x002462E8 File Offset: 0x002444E8
		// (set) Token: 0x06008542 RID: 34114 RVA: 0x0003F401 File Offset: 0x0003D601
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x00246310 File Offset: 0x00244510
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x0003F41C File Offset: 0x0003D61C
		public unsafe bool _IsDialHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x1700292F RID: 10543
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x00246338 File Offset: 0x00244538
		// (set) Token: 0x06008546 RID: 34118 RVA: 0x0003F437 File Offset: 0x0003D637
		public unsafe float _CurrentDialValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002930 RID: 10544
		// (get) Token: 0x06008547 RID: 34119 RVA: 0x00246360 File Offset: 0x00244560
		// (set) Token: 0x06008548 RID: 34120 RVA: 0x0003F452 File Offset: 0x0003D652
		public unsafe float _CurrentHeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField)) = value;
			}
		}

		// Token: 0x17002931 RID: 10545
		// (get) Token: 0x06008549 RID: 34121 RVA: 0x00246388 File Offset: 0x00244588
		// (set) Token: 0x0600854A RID: 34122 RVA: 0x0003F46D File Offset: 0x0003D66D
		public unsafe bool LockDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial)) = value;
			}
		}

		// Token: 0x17002932 RID: 10546
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x002463B0 File Offset: 0x002445B0
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x0003F488 File Offset: 0x0003D688
		public unsafe Gradient FlameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002933 RID: 10547
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x002463E0 File Offset: 0x002445E0
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x0003F4A7 File Offset: 0x0003D6A7
		public unsafe AnimationCurve LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x00246410 File Offset: 0x00244610
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x0003F4C6 File Offset: 0x0003D6C6
		public unsafe float HandleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed)) = value;
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x00246438 File Offset: 0x00244638
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x0003F4E1 File Offset: 0x0003D6E1
		public unsafe AnimationCurve FlamePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x00246468 File Offset: 0x00244668
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x0003F500 File Offset: 0x0003D700
		public unsafe ParticleSystem Flame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x00246498 File Offset: 0x00244698
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x0003F51F File Offset: 0x0003D71F
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x06008557 RID: 34135 RVA: 0x002464C8 File Offset: 0x002446C8
		// (set) Token: 0x06008558 RID: 34136 RVA: 0x0003F53E File Offset: 0x0003D73E
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x002464F8 File Offset: 0x002446F8
		// (set) Token: 0x0600855A RID: 34138 RVA: 0x0003F55D File Offset: 0x0003D75D
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600855B RID: 34139 RVA: 0x00246528 File Offset: 0x00244728
		// (set) Token: 0x0600855C RID: 34140 RVA: 0x0003F57C File Offset: 0x0003D77C
		public unsafe Transform Handle_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x00246558 File Offset: 0x00244758
		// (set) Token: 0x0600855E RID: 34142 RVA: 0x0003F59B File Offset: 0x0003D79B
		public unsafe Transform Handle_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600855F RID: 34143 RVA: 0x00246588 File Offset: 0x00244788
		// (set) Token: 0x06008560 RID: 34144 RVA: 0x0003F5BA File Offset: 0x0003D7BA
		public unsafe Transform Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x06008561 RID: 34145 RVA: 0x002465B8 File Offset: 0x002447B8
		// (set) Token: 0x06008562 RID: 34146 RVA: 0x0003F5D9 File Offset: 0x0003D7D9
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x002465E8 File Offset: 0x002447E8
		// (set) Token: 0x06008564 RID: 34148 RVA: 0x0003F5F8 File Offset: 0x0003D7F8
		public unsafe AudioSourceController FlameSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x00246618 File Offset: 0x00244818
		// (set) Token: 0x06008566 RID: 34150 RVA: 0x0003F617 File Offset: 0x0003D817
		public unsafe InputPromptsData _handlePromptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__handlePromptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__handlePromptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x00246648 File Offset: 0x00244848
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x0003F636 File Offset: 0x0003D836
		public unsafe Transform _handlePromptAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__handlePromptAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__handlePromptAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AEB RID: 23275
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04005AEC RID: 23276
		private static readonly IntPtr NativeFieldInfoPtr__IsDialHeld_k__BackingField;

		// Token: 0x04005AED RID: 23277
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDialValue_k__BackingField;

		// Token: 0x04005AEE RID: 23278
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHeat_k__BackingField;

		// Token: 0x04005AEF RID: 23279
		private static readonly IntPtr NativeFieldInfoPtr_LockDial;

		// Token: 0x04005AF0 RID: 23280
		private static readonly IntPtr NativeFieldInfoPtr_FlameColor;

		// Token: 0x04005AF1 RID: 23281
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x04005AF2 RID: 23282
		private static readonly IntPtr NativeFieldInfoPtr_HandleRotationSpeed;

		// Token: 0x04005AF3 RID: 23283
		private static readonly IntPtr NativeFieldInfoPtr_FlamePitch;

		// Token: 0x04005AF4 RID: 23284
		private static readonly IntPtr NativeFieldInfoPtr_Flame;

		// Token: 0x04005AF5 RID: 23285
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04005AF6 RID: 23286
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04005AF7 RID: 23287
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04005AF8 RID: 23288
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Min;

		// Token: 0x04005AF9 RID: 23289
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Max;

		// Token: 0x04005AFA RID: 23290
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x04005AFB RID: 23291
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005AFC RID: 23292
		private static readonly IntPtr NativeFieldInfoPtr_FlameSound;

		// Token: 0x04005AFD RID: 23293
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptData;

		// Token: 0x04005AFE RID: 23294
		private static readonly IntPtr NativeFieldInfoPtr__handlePromptAnchor;

		// Token: 0x04005AFF RID: 23295
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04005B00 RID: 23296
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04005B01 RID: 23297
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0;

		// Token: 0x04005B02 RID: 23298
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0;

		// Token: 0x04005B03 RID: 23299
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0;

		// Token: 0x04005B04 RID: 23300
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0;

		// Token: 0x04005B05 RID: 23301
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0;

		// Token: 0x04005B06 RID: 23302
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0;

		// Token: 0x04005B07 RID: 23303
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005B08 RID: 23304
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005B09 RID: 23305
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x04005B0A RID: 23306
		private static readonly IntPtr NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0;

		// Token: 0x04005B0B RID: 23307
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005B0C RID: 23308
		private static readonly IntPtr NativeMethodInfoPtr_GetDialValue_Private_Single_0;

		// Token: 0x04005B0D RID: 23309
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04005B0E RID: 23310
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04005B0F RID: 23311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
