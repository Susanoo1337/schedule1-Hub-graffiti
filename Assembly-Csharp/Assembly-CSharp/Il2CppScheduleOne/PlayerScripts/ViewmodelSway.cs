using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200032E RID: 814
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x001672D8 File Offset: 0x001654D8
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelSway()
		{
			Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelSway");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr);
			ViewmodelSway.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "DEBUG");
			ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingHeightMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_lastHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "lastHeight");
			ViewmodelSway.NativeFieldInfoPtr_breatheBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobPos");
			ViewmodelSway.NativeFieldInfoPtr_swayingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_maxHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxHorizontal");
			ViewmodelSway.NativeFieldInfoPtr_maxVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxVertical");
			ViewmodelSway.NativeFieldInfoPtr_swaySmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swaySmooth");
			ViewmodelSway.NativeFieldInfoPtr_returnMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "returnMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_initialPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "initialPos");
			ViewmodelSway.NativeFieldInfoPtr_swayPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayPos");
			ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_verticalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalMovement");
			ViewmodelSway.NativeFieldInfoPtr_horizontalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalMovement");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobHeight");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobWidth");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobSmooth");
			ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "sprintSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_vert");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_horiz");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltEnabled");
			ViewmodelSway.NativeFieldInfoPtr_jumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpCurve");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltHeight");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopVerticalOffset");
			ViewmodelSway.NativeFieldInfoPtr_equipBopTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopTime");
			ViewmodelSway.NativeFieldInfoPtr_equipBopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceJumpStart");
			ViewmodelSway.NativeFieldInfoPtr_jumpPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpPos");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetRate");
			ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxFallOffsetAmount");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetPos");
			ViewmodelSway.NativeFieldInfoPtr_landCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landCurve");
			ViewmodelSway.NativeFieldInfoPtr_landJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_landPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceLanded");
			ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltMultiplier");
			ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672250);
			ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672251);
			ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672252);
			ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672253);
			ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672254);
			ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672255);
			ViewmodelSway.NativeMethodInfoPtr_OnEquippedSlotChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672256);
			ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672257);
			ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672258);
			ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672259);
			ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672260);
			ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672261);
			ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672262);
			ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672263);
			ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100672264);
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x001677E0 File Offset: 0x001659E0
		public unsafe float calculatedJumpJoltHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x0016781C File Offset: 0x00165A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164444, XrefRangeEnd = 164447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00167858 File Offset: 0x00165A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164447, XrefRangeEnd = 164452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00167894 File Offset: 0x00165A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164452, XrefRangeEnd = 164525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x001678E0 File Offset: 0x00165AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164553, RefRangeEnd = 164555, XrefRangeStart = 164525, XrefRangeEnd = 164553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00167914 File Offset: 0x00165B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164555, XrefRangeEnd = 164556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InventoryStateChanged(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00167954 File Offset: 0x00165B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164556, XrefRangeEnd = 164557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEquippedSlotChanged(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_OnEquippedSlotChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00167994 File Offset: 0x00165B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164615, RefRangeEnd = 164617, XrefRangeStart = 164557, XrefRangeEnd = 164615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshViewmodel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x001679C8 File Offset: 0x00165BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164617, XrefRangeEnd = 164619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreatheBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001679FC File Offset: 0x00165BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164653, RefRangeEnd = 164654, XrefRangeStart = 164619, XrefRangeEnd = 164653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sway()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00167A30 File Offset: 0x00165C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164683, RefRangeEnd = 164684, XrefRangeStart = 164654, XrefRangeEnd = 164683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00167A64 File Offset: 0x00165C64
		[CallerCount(0)]
		public unsafe void StartJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00167A98 File Offset: 0x00165C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164721, RefRangeEnd = 164722, XrefRangeStart = 164684, XrefRangeEnd = 164721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00167ACC File Offset: 0x00165CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164722, XrefRangeEnd = 164724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Land()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00167B00 File Offset: 0x00165D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164724, XrefRangeEnd = 164735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelSway() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00021A68 File Offset: 0x0001FC68
		public ViewmodelSway(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00167B3C File Offset: 0x00165D3C
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x00021A71 File Offset: 0x0001FC71
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x00167B64 File Offset: 0x00165D64
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x00021A8C File Offset: 0x0001FC8C
		public unsafe bool breatheBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled)) = value;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00167B8C File Offset: 0x00165D8C
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x00021AA7 File Offset: 0x0001FCA7
		public unsafe float breathingHeightMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier)) = value;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00167BB4 File Offset: 0x00165DB4
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x00021AC2 File Offset: 0x0001FCC2
		public unsafe float breathingSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x00167BDC File Offset: 0x00165DDC
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x00021ADD File Offset: 0x0001FCDD
		public unsafe float lastHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight)) = value;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x00167C04 File Offset: 0x00165E04
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		public unsafe Vector3 breatheBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos)) = value;
			}
		}

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x00167C2C File Offset: 0x00165E2C
		// (set) Token: 0x06004550 RID: 17744 RVA: 0x00021B13 File Offset: 0x0001FD13
		public unsafe bool swayingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled)) = value;
			}
		}

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06004551 RID: 17745 RVA: 0x00167C54 File Offset: 0x00165E54
		// (set) Token: 0x06004552 RID: 17746 RVA: 0x00021B2E File Offset: 0x0001FD2E
		public unsafe float horizontalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier)) = value;
			}
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x00167C7C File Offset: 0x00165E7C
		// (set) Token: 0x06004554 RID: 17748 RVA: 0x00021B49 File Offset: 0x0001FD49
		public unsafe float verticalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier)) = value;
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06004555 RID: 17749 RVA: 0x00167CA4 File Offset: 0x00165EA4
		// (set) Token: 0x06004556 RID: 17750 RVA: 0x00021B64 File Offset: 0x0001FD64
		public unsafe float maxHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal)) = value;
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x00167CCC File Offset: 0x00165ECC
		// (set) Token: 0x06004558 RID: 17752 RVA: 0x00021B7F File Offset: 0x0001FD7F
		public unsafe float maxVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical)) = value;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x00167CF4 File Offset: 0x00165EF4
		// (set) Token: 0x0600455A RID: 17754 RVA: 0x00021B9A File Offset: 0x0001FD9A
		public unsafe float swaySmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth)) = value;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600455B RID: 17755 RVA: 0x00167D1C File Offset: 0x00165F1C
		// (set) Token: 0x0600455C RID: 17756 RVA: 0x00021BB5 File Offset: 0x0001FDB5
		public unsafe float returnMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier)) = value;
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x00167D44 File Offset: 0x00165F44
		// (set) Token: 0x0600455E RID: 17758 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		public unsafe Vector3 initialPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos)) = value;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x00167D6C File Offset: 0x00165F6C
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x00021BEB File Offset: 0x0001FDEB
		public unsafe Vector3 swayPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos)) = value;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x00167D94 File Offset: 0x00165F94
		// (set) Token: 0x06004562 RID: 17762 RVA: 0x00021C06 File Offset: 0x0001FE06
		public unsafe bool walkBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled)) = value;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06004563 RID: 17763 RVA: 0x00167DBC File Offset: 0x00165FBC
		// (set) Token: 0x06004564 RID: 17764 RVA: 0x00021C21 File Offset: 0x0001FE21
		public unsafe AnimationCurve verticalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x00167DEC File Offset: 0x00165FEC
		// (set) Token: 0x06004566 RID: 17766 RVA: 0x00021C40 File Offset: 0x0001FE40
		public unsafe AnimationCurve horizontalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x00167E1C File Offset: 0x0016601C
		// (set) Token: 0x06004568 RID: 17768 RVA: 0x00021C5F File Offset: 0x0001FE5F
		public unsafe float verticalBobHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight)) = value;
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x00167E44 File Offset: 0x00166044
		// (set) Token: 0x0600456A RID: 17770 RVA: 0x00021C7A File Offset: 0x0001FE7A
		public unsafe float verticalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed)) = value;
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x0600456B RID: 17771 RVA: 0x00167E6C File Offset: 0x0016606C
		// (set) Token: 0x0600456C RID: 17772 RVA: 0x00021C95 File Offset: 0x0001FE95
		public unsafe float horizontalBobWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth)) = value;
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x0600456D RID: 17773 RVA: 0x00167E94 File Offset: 0x00166094
		// (set) Token: 0x0600456E RID: 17774 RVA: 0x00021CB0 File Offset: 0x0001FEB0
		public unsafe float horizontalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed)) = value;
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x0600456F RID: 17775 RVA: 0x00167EBC File Offset: 0x001660BC
		// (set) Token: 0x06004570 RID: 17776 RVA: 0x00021CCB File Offset: 0x0001FECB
		public unsafe float walkBobSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth)) = value;
			}
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x00167EE4 File Offset: 0x001660E4
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x00021CE6 File Offset: 0x0001FEE6
		public unsafe float sprintSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x00167F0C File Offset: 0x0016610C
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x00021D01 File Offset: 0x0001FF01
		public unsafe float walkBobMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier)) = value;
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x00167F34 File Offset: 0x00166134
		// (set) Token: 0x06004576 RID: 17782 RVA: 0x00021D1C File Offset: 0x0001FF1C
		public unsafe Vector3 walkBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos)) = value;
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x00167F5C File Offset: 0x0016615C
		// (set) Token: 0x06004578 RID: 17784 RVA: 0x00021D37 File Offset: 0x0001FF37
		public unsafe float timeSinceWalkStart_vert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert)) = value;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x00167F84 File Offset: 0x00166184
		// (set) Token: 0x0600457A RID: 17786 RVA: 0x00021D52 File Offset: 0x0001FF52
		public unsafe float timeSinceWalkStart_horiz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz)) = value;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x0600457B RID: 17787 RVA: 0x00167FAC File Offset: 0x001661AC
		// (set) Token: 0x0600457C RID: 17788 RVA: 0x00021D6D File Offset: 0x0001FF6D
		public unsafe bool jumpJoltEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled)) = value;
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x00167FD4 File Offset: 0x001661D4
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x00021D88 File Offset: 0x0001FF88
		public unsafe AnimationCurve jumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x00168004 File Offset: 0x00166204
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x00021DA7 File Offset: 0x0001FFA7
		public unsafe float jumpJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime)) = value;
			}
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x0016802C File Offset: 0x0016622C
		// (set) Token: 0x06004582 RID: 17794 RVA: 0x00021DC2 File Offset: 0x0001FFC2
		public unsafe float jumpJoltHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight)) = value;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x00168054 File Offset: 0x00166254
		// (set) Token: 0x06004584 RID: 17796 RVA: 0x00021DDD File Offset: 0x0001FFDD
		public unsafe float jumpJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth)) = value;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x0016807C File Offset: 0x0016627C
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x00021DF8 File Offset: 0x0001FFF8
		public unsafe float equipBopVerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset)) = value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x001680A4 File Offset: 0x001662A4
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x00021E13 File Offset: 0x00020013
		public unsafe float equipBopTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime)) = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x001680CC File Offset: 0x001662CC
		// (set) Token: 0x0600458A RID: 17802 RVA: 0x00021E2E File Offset: 0x0002002E
		public unsafe Vector3 equipBopPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos)) = value;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x001680F4 File Offset: 0x001662F4
		// (set) Token: 0x0600458C RID: 17804 RVA: 0x00021E49 File Offset: 0x00020049
		public unsafe float timeSinceJumpStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart)) = value;
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x0016811C File Offset: 0x0016631C
		// (set) Token: 0x0600458E RID: 17806 RVA: 0x00021E64 File Offset: 0x00020064
		public unsafe Vector3 jumpPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos)) = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x00168144 File Offset: 0x00166344
		// (set) Token: 0x06004590 RID: 17808 RVA: 0x00021E7F File Offset: 0x0002007F
		public unsafe float fallOffsetRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate)) = value;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x0016816C File Offset: 0x0016636C
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x00021E9A File Offset: 0x0002009A
		public unsafe float maxFallOffsetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount)) = value;
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x00168194 File Offset: 0x00166394
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x00021EB5 File Offset: 0x000200B5
		public unsafe Vector3 fallOffsetPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos)) = value;
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x001681BC File Offset: 0x001663BC
		// (set) Token: 0x06004596 RID: 17814 RVA: 0x00021ED0 File Offset: 0x000200D0
		public unsafe AnimationCurve landCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x001681EC File Offset: 0x001663EC
		// (set) Token: 0x06004598 RID: 17816 RVA: 0x00021EEF File Offset: 0x000200EF
		public unsafe float landJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime)) = value;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x00168214 File Offset: 0x00166414
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x00021F0A File Offset: 0x0002010A
		public unsafe float landJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth)) = value;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x0016823C File Offset: 0x0016643C
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x00021F25 File Offset: 0x00020125
		public unsafe Vector3 landPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos)) = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x00168264 File Offset: 0x00166464
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x00021F40 File Offset: 0x00020140
		public unsafe float timeSinceLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded)) = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x0016828C File Offset: 0x0016648C
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x00021F5B File Offset: 0x0002015B
		public unsafe float landJoltMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier)) = value;
			}
		}

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobbingEnabled;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeFieldInfoPtr_breathingHeightMultiplier;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeFieldInfoPtr_breathingSpeedMultiplier;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeFieldInfoPtr_lastHeight;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobPos;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeFieldInfoPtr_swayingEnabled;

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeFieldInfoPtr_horizontalSwayMultiplier;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeFieldInfoPtr_verticalSwayMultiplier;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeFieldInfoPtr_maxHorizontal;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeFieldInfoPtr_maxVertical;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeFieldInfoPtr_swaySmooth;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeFieldInfoPtr_returnMultiplier;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeFieldInfoPtr_initialPos;

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeFieldInfoPtr_swayPos;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeFieldInfoPtr_walkBobbingEnabled;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeFieldInfoPtr_verticalMovement;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMovement;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobHeight;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobSpeed;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobWidth;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobSpeed;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeFieldInfoPtr_walkBobSmooth;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeFieldInfoPtr_sprintSpeedMultiplier;

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeFieldInfoPtr_walkBobMultiplier;

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeFieldInfoPtr_walkBobPos;

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_vert;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_horiz;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltEnabled;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeFieldInfoPtr_jumpCurve;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltTime;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltHeight;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltSmooth;

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeFieldInfoPtr_equipBopVerticalOffset;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeFieldInfoPtr_equipBopTime;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeFieldInfoPtr_equipBopPos;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceJumpStart;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeFieldInfoPtr_jumpPos;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetRate;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeFieldInfoPtr_maxFallOffsetAmount;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetPos;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeFieldInfoPtr_landCurve;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeFieldInfoPtr_landJoltTime;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeFieldInfoPtr_landJoltSmooth;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeFieldInfoPtr_landPos;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLanded;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeFieldInfoPtr_landJoltMultiplier;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0;

		// Token: 0x04002F5C RID: 12124
		private static readonly IntPtr NativeMethodInfoPtr_OnEquippedSlotChanged_Private_Void_Int32_0;

		// Token: 0x04002F5D RID: 12125
		private static readonly IntPtr NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0;

		// Token: 0x04002F5E RID: 12126
		private static readonly IntPtr NativeMethodInfoPtr_BreatheBob_Protected_Void_0;

		// Token: 0x04002F5F RID: 12127
		private static readonly IntPtr NativeMethodInfoPtr_Sway_Protected_Void_0;

		// Token: 0x04002F60 RID: 12128
		private static readonly IntPtr NativeMethodInfoPtr_WalkBob_Protected_Void_0;

		// Token: 0x04002F61 RID: 12129
		private static readonly IntPtr NativeMethodInfoPtr_StartJump_Protected_Void_0;

		// Token: 0x04002F62 RID: 12130
		private static readonly IntPtr NativeMethodInfoPtr_UpdateJump_Protected_Void_0;

		// Token: 0x04002F63 RID: 12131
		private static readonly IntPtr NativeMethodInfoPtr_Land_Protected_Void_0;

		// Token: 0x04002F64 RID: 12132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
