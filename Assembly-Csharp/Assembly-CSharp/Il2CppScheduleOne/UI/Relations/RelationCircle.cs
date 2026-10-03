using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Framework;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Relations
{
	// Token: 0x020007A1 RID: 1953
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x0600BCA9 RID: 48297 RVA: 0x00306E78 File Offset: 0x00305078
		// Note: this type is marked as 'beforefieldinit'.
		static RelationCircle()
		{
			Il2CppClassPointerStore<RelationCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Relations", "RelationCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr);
			RelationCircle.NativeFieldInfoPtr_NotchMinRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMinRot");
			RelationCircle.NativeFieldInfoPtr_NotchMaxRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchMaxRot");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_ZeroDependence");
			RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitColor_MaxDependence");
			RelationCircle.NativeFieldInfoPtr_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NPC");
			RelationCircle.NativeFieldInfoPtr_AssignedNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AssignedNPC");
			RelationCircle.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onClicked");
			RelationCircle.NativeFieldInfoPtr_onHoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverStart");
			RelationCircle.NativeFieldInfoPtr_onHoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "onHoverEnd");
			RelationCircle.NativeFieldInfoPtr_AutoSetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "AutoSetName");
			RelationCircle.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Rect");
			RelationCircle.NativeFieldInfoPtr_PortraitBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "PortraitBackground");
			RelationCircle.NativeFieldInfoPtr_HeadshotImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "HeadshotImg");
			RelationCircle.NativeFieldInfoPtr_NotchPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "NotchPivot");
			RelationCircle.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Locked");
			RelationCircle.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Button");
			RelationCircle.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "Trigger");
			RelationCircle.NativeFieldInfoPtr_uiMapItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, "uiMapItem");
			RelationCircle.NativeMethodInfoPtr_get_NPCId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687918);
			RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687919);
			RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687920);
			RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687921);
			RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687922);
			RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687923);
			RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687924);
			RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687925);
			RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687926);
			RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687927);
			RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687928);
			RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687929);
			RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687930);
			RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687931);
			RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687932);
			RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687933);
			RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687934);
			RelationCircle.NativeMethodInfoPtr__Awake_b__20_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687936);
			RelationCircle.NativeMethodInfoPtr__Awake_b__20_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687937);
			RelationCircle.NativeMethodInfoPtr__AssignNPC_b__21_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr, 100687938);
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600BCAA RID: 48298 RVA: 0x003071A0 File Offset: 0x003053A0
		public unsafe string NPCId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 314433, RefRangeEnd = 314440, XrefRangeStart = 314427, XrefRangeEnd = 314433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_get_NPCId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600BCAB RID: 48299 RVA: 0x003071D8 File Offset: 0x003053D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314440, XrefRangeEnd = 314505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x0030720C File Offset: 0x0030540C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314586, RefRangeEnd = 314588, XrefRangeStart = 314505, XrefRangeEnd = 314586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x00307250 File Offset: 0x00305450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314588, XrefRangeEnd = 314606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UnassignNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x00307284 File Offset: 0x00305484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314606, XrefRangeEnd = 314607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x003072C4 File Offset: 0x003054C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314610, RefRangeEnd = 314613, XrefRangeStart = 314607, XrefRangeEnd = 314610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotchPosition(float relationshipDelta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationshipDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x00307304 File Offset: 0x00305504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314616, RefRangeEnd = 314618, XrefRangeStart = 314613, XrefRangeEnd = 314616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotchPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB1 RID: 48305 RVA: 0x00307338 File Offset: 0x00305538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314631, RefRangeEnd = 314632, XrefRangeStart = 314618, XrefRangeEnd = 314631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDependenceDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x0030736C File Offset: 0x0030556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314632, XrefRangeEnd = 314637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x003073A0 File Offset: 0x003055A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314641, RefRangeEnd = 314642, XrefRangeStart = 314637, XrefRangeEnd = 314641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x003073EC File Offset: 0x003055EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314648, RefRangeEnd = 314649, XrefRangeStart = 314642, XrefRangeEnd = 314648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_LoadNPCData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x00307420 File Offset: 0x00305620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314669, RefRangeEnd = 314671, XrefRangeStart = 314649, XrefRangeEnd = 314669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBlackout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_UpdateBlackout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x00307454 File Offset: 0x00305654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314672, RefRangeEnd = 314673, XrefRangeStart = 314671, XrefRangeEnd = 314672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackedOut(bool blackedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blackedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB7 RID: 48311 RVA: 0x00307494 File Offset: 0x00305694
		[CallerCount(0)]
		public unsafe void ButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x003074C8 File Offset: 0x003056C8
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x003074FC File Offset: 0x003056FC
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x00307530 File Offset: 0x00305730
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x0030756C File Offset: 0x0030576C
		[CallerCount(0)]
		public unsafe void _Awake_b__20_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__20_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x003075B0 File Offset: 0x003057B0
		[CallerCount(0)]
		public unsafe void _Awake_b__20_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__Awake_b__20_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x003075F4 File Offset: 0x003057F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314673, XrefRangeEnd = 314674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AssignNPC_b__21_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationCircle.NativeMethodInfoPtr__AssignNPC_b__21_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BCBE RID: 48318 RVA: 0x00057DCB File Offset: 0x00055FCB
		public RelationCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x00307640 File Offset: 0x00305840
		// (set) Token: 0x0600BCC0 RID: 48320 RVA: 0x00057DD4 File Offset: 0x00055FD4
		public unsafe static float NotchMinRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMinRot, (void*)(&value));
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x0030765C File Offset: 0x0030585C
		// (set) Token: 0x0600BCC2 RID: 48322 RVA: 0x00057DE2 File Offset: 0x00055FE2
		public unsafe static float NotchMaxRot
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_NotchMaxRot, (void*)(&value));
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600BCC3 RID: 48323 RVA: 0x00307678 File Offset: 0x00305878
		// (set) Token: 0x0600BCC4 RID: 48324 RVA: 0x00057DF0 File Offset: 0x00055FF0
		public unsafe static Color PortraitColor_ZeroDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_ZeroDependence, (void*)(&value));
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600BCC5 RID: 48325 RVA: 0x00307694 File Offset: 0x00305894
		// (set) Token: 0x0600BCC6 RID: 48326 RVA: 0x00057DFE File Offset: 0x00055FFE
		public unsafe static Color PortraitColor_MaxDependence
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationCircle.NativeFieldInfoPtr_PortraitColor_MaxDependence, (void*)(&value));
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x003076B0 File Offset: 0x003058B0
		// (set) Token: 0x0600BCC8 RID: 48328 RVA: 0x00057E0C File Offset: 0x0005600C
		public unsafe BaseNPCDataObject NPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseNPCDataObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600BCC9 RID: 48329 RVA: 0x003076E0 File Offset: 0x003058E0
		// (set) Token: 0x0600BCCA RID: 48330 RVA: 0x00057E2B File Offset: 0x0005602B
		public unsafe NPC AssignedNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AssignedNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600BCCB RID: 48331 RVA: 0x00307710 File Offset: 0x00305910
		// (set) Token: 0x0600BCCC RID: 48332 RVA: 0x00057E4A File Offset: 0x0005604A
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x00307740 File Offset: 0x00305940
		// (set) Token: 0x0600BCCE RID: 48334 RVA: 0x00057E69 File Offset: 0x00056069
		public unsafe Action onHoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600BCCF RID: 48335 RVA: 0x00307770 File Offset: 0x00305970
		// (set) Token: 0x0600BCD0 RID: 48336 RVA: 0x00057E88 File Offset: 0x00056088
		public unsafe Action onHoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_onHoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600BCD1 RID: 48337 RVA: 0x003077A0 File Offset: 0x003059A0
		// (set) Token: 0x0600BCD2 RID: 48338 RVA: 0x00057EA7 File Offset: 0x000560A7
		public unsafe bool AutoSetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_AutoSetName)) = value;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x003077C8 File Offset: 0x003059C8
		// (set) Token: 0x0600BCD4 RID: 48340 RVA: 0x00057EC2 File Offset: 0x000560C2
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600BCD5 RID: 48341 RVA: 0x003077F8 File Offset: 0x003059F8
		// (set) Token: 0x0600BCD6 RID: 48342 RVA: 0x00057EE1 File Offset: 0x000560E1
		public unsafe Image PortraitBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_PortraitBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600BCD7 RID: 48343 RVA: 0x00307828 File Offset: 0x00305A28
		// (set) Token: 0x0600BCD8 RID: 48344 RVA: 0x00057F00 File Offset: 0x00056100
		public unsafe Image HeadshotImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_HeadshotImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600BCD9 RID: 48345 RVA: 0x00307858 File Offset: 0x00305A58
		// (set) Token: 0x0600BCDA RID: 48346 RVA: 0x00057F1F File Offset: 0x0005611F
		public unsafe RectTransform NotchPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_NotchPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600BCDB RID: 48347 RVA: 0x00307888 File Offset: 0x00305A88
		// (set) Token: 0x0600BCDC RID: 48348 RVA: 0x00057F3E File Offset: 0x0005613E
		public unsafe RectTransform Locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Locked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600BCDD RID: 48349 RVA: 0x003078B8 File Offset: 0x00305AB8
		// (set) Token: 0x0600BCDE RID: 48350 RVA: 0x00057F5D File Offset: 0x0005615D
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x003078E8 File Offset: 0x00305AE8
		// (set) Token: 0x0600BCE0 RID: 48352 RVA: 0x00057F7C File Offset: 0x0005617C
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600BCE1 RID: 48353 RVA: 0x00307918 File Offset: 0x00305B18
		// (set) Token: 0x0600BCE2 RID: 48354 RVA: 0x00057F9B File Offset: 0x0005619B
		public unsafe UIMapItem uiMapItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_uiMapItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIMapItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationCircle.NativeFieldInfoPtr_uiMapItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008146 RID: 33094
		private static readonly IntPtr NativeFieldInfoPtr_NotchMinRot;

		// Token: 0x04008147 RID: 33095
		private static readonly IntPtr NativeFieldInfoPtr_NotchMaxRot;

		// Token: 0x04008148 RID: 33096
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_ZeroDependence;

		// Token: 0x04008149 RID: 33097
		private static readonly IntPtr NativeFieldInfoPtr_PortraitColor_MaxDependence;

		// Token: 0x0400814A RID: 33098
		private static readonly IntPtr NativeFieldInfoPtr_NPC;

		// Token: 0x0400814B RID: 33099
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPC;

		// Token: 0x0400814C RID: 33100
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x0400814D RID: 33101
		private static readonly IntPtr NativeFieldInfoPtr_onHoverStart;

		// Token: 0x0400814E RID: 33102
		private static readonly IntPtr NativeFieldInfoPtr_onHoverEnd;

		// Token: 0x0400814F RID: 33103
		private static readonly IntPtr NativeFieldInfoPtr_AutoSetName;

		// Token: 0x04008150 RID: 33104
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04008151 RID: 33105
		private static readonly IntPtr NativeFieldInfoPtr_PortraitBackground;

		// Token: 0x04008152 RID: 33106
		private static readonly IntPtr NativeFieldInfoPtr_HeadshotImg;

		// Token: 0x04008153 RID: 33107
		private static readonly IntPtr NativeFieldInfoPtr_NotchPivot;

		// Token: 0x04008154 RID: 33108
		private static readonly IntPtr NativeFieldInfoPtr_Locked;

		// Token: 0x04008155 RID: 33109
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04008156 RID: 33110
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04008157 RID: 33111
		private static readonly IntPtr NativeFieldInfoPtr_uiMapItem;

		// Token: 0x04008158 RID: 33112
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCId_Public_get_String_0;

		// Token: 0x04008159 RID: 33113
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400815A RID: 33114
		private static readonly IntPtr NativeMethodInfoPtr_AssignNPC_Public_Void_NPC_0;

		// Token: 0x0400815B RID: 33115
		private static readonly IntPtr NativeMethodInfoPtr_UnassignNPC_Private_Void_0;

		// Token: 0x0400815C RID: 33116
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Private_Void_Single_0;

		// Token: 0x0400815D RID: 33117
		private static readonly IntPtr NativeMethodInfoPtr_SetNotchPosition_Public_Void_Single_0;

		// Token: 0x0400815E RID: 33118
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotchPosition_Private_Void_0;

		// Token: 0x0400815F RID: 33119
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDependenceDisplay_Private_Void_0;

		// Token: 0x04008160 RID: 33120
		private static readonly IntPtr NativeMethodInfoPtr_SetLocked_Public_Void_0;

		// Token: 0x04008161 RID: 33121
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_EUnlockType_Boolean_0;

		// Token: 0x04008162 RID: 33122
		private static readonly IntPtr NativeMethodInfoPtr_LoadNPCData_Public_Void_0;

		// Token: 0x04008163 RID: 33123
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlackout_Private_Void_0;

		// Token: 0x04008164 RID: 33124
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackedOut_Public_Void_Boolean_0;

		// Token: 0x04008165 RID: 33125
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

		// Token: 0x04008166 RID: 33126
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04008167 RID: 33127
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04008168 RID: 33128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008169 RID: 33129
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__20_0_Private_Void_BaseEventData_0;

		// Token: 0x0400816A RID: 33130
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__20_1_Private_Void_BaseEventData_0;

		// Token: 0x0400816B RID: 33131
		private static readonly IntPtr NativeMethodInfoPtr__AssignNPC_b__21_0_Private_Void_EUnlockType_Boolean_0;
	}
}
