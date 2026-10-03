using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000508 RID: 1288
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x060073E1 RID: 29665 RVA: 0x00207908 File Offset: 0x00205B08
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingTool()
		{
			Il2CppClassPointerStore<PackagingTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "PackagingTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr);
			PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<ReceiveInput>k__BackingField");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Min");
			PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizeRange_Max");
			PackagingTool.NativeFieldInfoPtr_ConveyorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorSpeed");
			PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorAcceleration");
			PackagingTool.NativeFieldInfoPtr_BaggieRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieRadius");
			PackagingTool.NativeFieldInfoPtr_JarRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarRadius");
			PackagingTool.NativeFieldInfoPtr_DeployAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DeployAngle");
			PackagingTool.NativeFieldInfoPtr_ProductInitialForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInitialForce");
			PackagingTool.NativeFieldInfoPtr_ProductRandomTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductRandomTorque");
			PackagingTool.NativeFieldInfoPtr_KickForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickForce");
			PackagingTool.NativeFieldInfoPtr_DropCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropCooldown");
			PackagingTool.NativeFieldInfoPtr_Station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "Station");
			PackagingTool.NativeFieldInfoPtr_ConveyorModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConveyorModel");
			PackagingTool.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DoorAnim");
			PackagingTool.NativeFieldInfoPtr_CapAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "CapAnim");
			PackagingTool.NativeFieldInfoPtr_SealAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "SealAnim");
			PackagingTool.NativeFieldInfoPtr_KickAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickAnim");
			PackagingTool.NativeFieldInfoPtr_LeftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "LeftButton");
			PackagingTool.NativeFieldInfoPtr_RightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "RightButton");
			PackagingTool.NativeFieldInfoPtr_DropButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropButton");
			PackagingTool.NativeFieldInfoPtr_PackagingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingContainer");
			PackagingTool.NativeFieldInfoPtr_ProductCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductCountText");
			PackagingTool.NativeFieldInfoPtr_HopperDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperDropPoint");
			PackagingTool.NativeFieldInfoPtr_BaggieStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "BaggieStartPoint");
			PackagingTool.NativeFieldInfoPtr_JarStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "JarStartPoint");
			PackagingTool.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductContainer");
			PackagingTool.NativeFieldInfoPtr_KickOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickOrigin");
			PackagingTool.NativeFieldInfoPtr_HopperInputCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "HopperInputCollider");
			PackagingTool.NativeFieldInfoPtr_KickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "KickSound");
			PackagingTool.NativeFieldInfoPtr_MotorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "MotorSound");
			PackagingTool.NativeFieldInfoPtr_DropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "DropSound");
			PackagingTool.NativeFieldInfoPtr__dropAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "_dropAction");
			PackagingTool.NativeFieldInfoPtr_PackagingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingPrefab");
			PackagingTool.NativeFieldInfoPtr_ConcealedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ConcealedPackaging");
			PackagingTool.NativeFieldInfoPtr_ProductItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductItem");
			PackagingTool.NativeFieldInfoPtr_ProductPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductPrefab");
			PackagingTool.NativeFieldInfoPtr_ProductInHopper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInHopper");
			PackagingTool.NativeFieldInfoPtr_PackagingInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstances");
			PackagingTool.NativeFieldInfoPtr_ProductInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "ProductInstances");
			PackagingTool.NativeFieldInfoPtr_FinalizedPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "FinalizedPackaging");
			PackagingTool.NativeFieldInfoPtr_conveyorVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "conveyorVelocity");
			PackagingTool.NativeFieldInfoPtr_directionInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "directionInput");
			PackagingTool.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "task");
			PackagingTool.NativeFieldInfoPtr_finalizeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "finalizeCoroutine");
			PackagingTool.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "leftDown");
			PackagingTool.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "rightDown");
			PackagingTool.NativeFieldInfoPtr_dropDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "dropDown");
			PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "timeSinceLastDrop");
			PackagingTool.NativeFieldInfoPtr_gamepadDropButtonReleasedSinceTaskBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "gamepadDropButtonReleasedSinceTaskBegin");
			PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678252);
			PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678253);
			PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678254);
			PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678255);
			PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678256);
			PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678257);
			PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678258);
			PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678259);
			PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678260);
			PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678261);
			PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678262);
			PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678263);
			PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678264);
			PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678265);
			PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678266);
			PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678267);
			PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678268);
			PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678269);
			PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678270);
			PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678271);
			PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, 100678272);
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x00207EC4 File Offset: 0x002060C4
		// (set) Token: 0x060073E3 RID: 29667 RVA: 0x00207F00 File Offset: 0x00206100
		public unsafe bool ReceiveInput
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x00207F40 File Offset: 0x00206140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227871, RefRangeEnd = 227872, XrefRangeStart = 227860, XrefRangeEnd = 227871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_task);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(packaging);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref packagingQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x00207FC4 File Offset: 0x002061C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227918, RefRangeEnd = 227919, XrefRangeStart = 227872, XrefRangeEnd = 227918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Deinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00207FF8 File Offset: 0x002061F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227919, XrefRangeEnd = 227920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00208048 File Offset: 0x00206248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227920, XrefRangeEnd = 227921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x0020807C File Offset: 0x0020627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227921, XrefRangeEnd = 227928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProduct(ProductItemInstance product, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x002080CC File Offset: 0x002062CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227928, XrefRangeEnd = 227933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UnloadProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x00208100 File Offset: 0x00206300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227933, XrefRangeEnd = 227963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x00208134 File Offset: 0x00206334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227983, RefRangeEnd = 227984, XrefRangeStart = 227963, XrefRangeEnd = 227983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x00208168 File Offset: 0x00206368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227988, RefRangeEnd = 227992, XrefRangeStart = 227984, XrefRangeEnd = 227988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x0020819C File Offset: 0x0020639C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227992, XrefRangeEnd = 227997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConveyor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_UpdateConveyor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x002081D0 File Offset: 0x002063D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228025, RefRangeEnd = 228028, XrefRangeStart = 227997, XrefRangeEnd = 228025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Rotate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x00208210 File Offset: 0x00206410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228035, RefRangeEnd = 228037, XrefRangeStart = 228028, XrefRangeEnd = 228035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x00208244 File Offset: 0x00206444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228037, XrefRangeEnd = 228049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckFinalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckFinalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x00208278 File Offset: 0x00206478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228063, RefRangeEnd = 228065, XrefRangeStart = 228049, XrefRangeEnd = 228063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finalize(PackagingTool.PackagingInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x002082BC File Offset: 0x002064BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228085, RefRangeEnd = 228086, XrefRangeStart = 228065, XrefRangeEnd = 228085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DropProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x002082F0 File Offset: 0x002064F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228107, RefRangeEnd = 228108, XrefRangeStart = 228086, XrefRangeEnd = 228107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInsertions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_CheckInsertions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x00208324 File Offset: 0x00206524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228119, RefRangeEnd = 228120, XrefRangeStart = 228108, XrefRangeEnd = 228119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertIntoHopper(FunctionalProduct product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x00208368 File Offset: 0x00206568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228196, RefRangeEnd = 228197, XrefRangeStart = 228120, XrefRangeEnd = 228196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployPackaging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr_DeployPackaging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x0020839C File Offset: 0x0020659C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228197, XrefRangeEnd = 228219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x00037247 File Offset: 0x00035447
		public PackagingTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x002083D8 File Offset: 0x002065D8
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x00037250 File Offset: 0x00035450
		public unsafe bool _ReceiveInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__ReceiveInput_k__BackingField)) = value;
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x00208400 File Offset: 0x00206600
		// (set) Token: 0x060073FB RID: 29691 RVA: 0x0003726B File Offset: 0x0003546B
		public unsafe static float FinalizeRange_Min
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Min, (void*)(&value));
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x0020841C File Offset: 0x0020661C
		// (set) Token: 0x060073FD RID: 29693 RVA: 0x00037279 File Offset: 0x00035479
		public unsafe static float FinalizeRange_Max
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PackagingTool.NativeFieldInfoPtr_FinalizeRange_Max, (void*)(&value));
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x00208438 File Offset: 0x00206638
		// (set) Token: 0x060073FF RID: 29695 RVA: 0x00037287 File Offset: 0x00035487
		public unsafe float ConveyorSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorSpeed)) = value;
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x00208460 File Offset: 0x00206660
		// (set) Token: 0x06007401 RID: 29697 RVA: 0x000372A2 File Offset: 0x000354A2
		public unsafe float ConveyorAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorAcceleration)) = value;
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x00208488 File Offset: 0x00206688
		// (set) Token: 0x06007403 RID: 29699 RVA: 0x000372BD File Offset: 0x000354BD
		public unsafe float BaggieRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieRadius)) = value;
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x002084B0 File Offset: 0x002066B0
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x000372D8 File Offset: 0x000354D8
		public unsafe float JarRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarRadius)) = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x002084D8 File Offset: 0x002066D8
		// (set) Token: 0x06007407 RID: 29703 RVA: 0x000372F3 File Offset: 0x000354F3
		public unsafe float DeployAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DeployAngle)) = value;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x06007408 RID: 29704 RVA: 0x00208500 File Offset: 0x00206700
		// (set) Token: 0x06007409 RID: 29705 RVA: 0x0003730E File Offset: 0x0003550E
		public unsafe float ProductInitialForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInitialForce)) = value;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x00208528 File Offset: 0x00206728
		// (set) Token: 0x0600740B RID: 29707 RVA: 0x00037329 File Offset: 0x00035529
		public unsafe float ProductRandomTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductRandomTorque)) = value;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x00208550 File Offset: 0x00206750
		// (set) Token: 0x0600740D RID: 29709 RVA: 0x00037344 File Offset: 0x00035544
		public unsafe float KickForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickForce)) = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x00208578 File Offset: 0x00206778
		// (set) Token: 0x0600740F RID: 29711 RVA: 0x0003735F File Offset: 0x0003555F
		public unsafe float DropCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropCooldown)) = value;
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x002085A0 File Offset: 0x002067A0
		// (set) Token: 0x06007411 RID: 29713 RVA: 0x0003737A File Offset: 0x0003557A
		public unsafe PackagingStation Station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_Station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x002085D0 File Offset: 0x002067D0
		// (set) Token: 0x06007413 RID: 29715 RVA: 0x00037399 File Offset: 0x00035599
		public unsafe Transform ConveyorModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConveyorModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x00208600 File Offset: 0x00206800
		// (set) Token: 0x06007415 RID: 29717 RVA: 0x000373B8 File Offset: 0x000355B8
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x00208630 File Offset: 0x00206830
		// (set) Token: 0x06007417 RID: 29719 RVA: 0x000373D7 File Offset: 0x000355D7
		public unsafe Animation CapAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_CapAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x00208660 File Offset: 0x00206860
		// (set) Token: 0x06007419 RID: 29721 RVA: 0x000373F6 File Offset: 0x000355F6
		public unsafe Animation SealAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_SealAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x00208690 File Offset: 0x00206890
		// (set) Token: 0x0600741B RID: 29723 RVA: 0x00037415 File Offset: 0x00035615
		public unsafe Animation KickAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x002086C0 File Offset: 0x002068C0
		// (set) Token: 0x0600741D RID: 29725 RVA: 0x00037434 File Offset: 0x00035634
		public unsafe Clickable LeftButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_LeftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x002086F0 File Offset: 0x002068F0
		// (set) Token: 0x0600741F RID: 29727 RVA: 0x00037453 File Offset: 0x00035653
		public unsafe Clickable RightButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_RightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x00208720 File Offset: 0x00206920
		// (set) Token: 0x06007421 RID: 29729 RVA: 0x00037472 File Offset: 0x00035672
		public unsafe Clickable DropButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x00208750 File Offset: 0x00206950
		// (set) Token: 0x06007423 RID: 29731 RVA: 0x00037491 File Offset: 0x00035691
		public unsafe Transform PackagingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06007424 RID: 29732 RVA: 0x00208780 File Offset: 0x00206980
		// (set) Token: 0x06007425 RID: 29733 RVA: 0x000374B0 File Offset: 0x000356B0
		public unsafe TextMeshPro ProductCountText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x002087B0 File Offset: 0x002069B0
		// (set) Token: 0x06007427 RID: 29735 RVA: 0x000374CF File Offset: 0x000356CF
		public unsafe Transform HopperDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06007428 RID: 29736 RVA: 0x002087E0 File Offset: 0x002069E0
		// (set) Token: 0x06007429 RID: 29737 RVA: 0x000374EE File Offset: 0x000356EE
		public unsafe Transform BaggieStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_BaggieStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600742A RID: 29738 RVA: 0x00208810 File Offset: 0x00206A10
		// (set) Token: 0x0600742B RID: 29739 RVA: 0x0003750D File Offset: 0x0003570D
		public unsafe Transform JarStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_JarStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600742C RID: 29740 RVA: 0x00208840 File Offset: 0x00206A40
		// (set) Token: 0x0600742D RID: 29741 RVA: 0x0003752C File Offset: 0x0003572C
		public unsafe Transform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600742E RID: 29742 RVA: 0x00208870 File Offset: 0x00206A70
		// (set) Token: 0x0600742F RID: 29743 RVA: 0x0003754B File Offset: 0x0003574B
		public unsafe Transform KickOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x002088A0 File Offset: 0x00206AA0
		// (set) Token: 0x06007431 RID: 29745 RVA: 0x0003756A File Offset: 0x0003576A
		public unsafe SphereCollider HopperInputCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_HopperInputCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x06007432 RID: 29746 RVA: 0x002088D0 File Offset: 0x00206AD0
		// (set) Token: 0x06007433 RID: 29747 RVA: 0x00037589 File Offset: 0x00035789
		public unsafe AudioSourceController KickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_KickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x06007434 RID: 29748 RVA: 0x00208900 File Offset: 0x00206B00
		// (set) Token: 0x06007435 RID: 29749 RVA: 0x000375A8 File Offset: 0x000357A8
		public unsafe AudioSourceController MotorSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_MotorSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x00208930 File Offset: 0x00206B30
		// (set) Token: 0x06007437 RID: 29751 RVA: 0x000375C7 File Offset: 0x000357C7
		public unsafe AudioSourceController DropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_DropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x00208960 File Offset: 0x00206B60
		// (set) Token: 0x06007439 RID: 29753 RVA: 0x000375E6 File Offset: 0x000357E6
		public unsafe InputActionReference _dropAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__dropAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr__dropAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600743A RID: 29754 RVA: 0x00208990 File Offset: 0x00206B90
		// (set) Token: 0x0600743B RID: 29755 RVA: 0x00037605 File Offset: 0x00035805
		public unsafe FunctionalPackaging PackagingPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600743C RID: 29756 RVA: 0x002089C0 File Offset: 0x00206BC0
		// (set) Token: 0x0600743D RID: 29757 RVA: 0x00037624 File Offset: 0x00035824
		public unsafe int ConcealedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ConcealedPackaging)) = value;
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x002089E8 File Offset: 0x00206BE8
		// (set) Token: 0x0600743F RID: 29759 RVA: 0x0003763F File Offset: 0x0003583F
		public unsafe ProductItemInstance ProductItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06007440 RID: 29760 RVA: 0x00208A18 File Offset: 0x00206C18
		// (set) Token: 0x06007441 RID: 29761 RVA: 0x0003765E File Offset: 0x0003585E
		public unsafe FunctionalProduct ProductPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x00208A48 File Offset: 0x00206C48
		// (set) Token: 0x06007443 RID: 29763 RVA: 0x0003767D File Offset: 0x0003587D
		public unsafe int ProductInHopper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInHopper)) = value;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x06007444 RID: 29764 RVA: 0x00208A70 File Offset: 0x00206C70
		// (set) Token: 0x06007445 RID: 29765 RVA: 0x00037698 File Offset: 0x00035898
		public unsafe List<PackagingTool.PackagingInstance> PackagingInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingTool.PackagingInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_PackagingInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x00208AA0 File Offset: 0x00206CA0
		// (set) Token: 0x06007447 RID: 29767 RVA: 0x000376B7 File Offset: 0x000358B7
		public unsafe List<FunctionalProduct> ProductInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_ProductInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x00208AD0 File Offset: 0x00206CD0
		// (set) Token: 0x06007449 RID: 29769 RVA: 0x000376D6 File Offset: 0x000358D6
		public unsafe List<FunctionalPackaging> FinalizedPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalPackaging>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_FinalizedPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600744A RID: 29770 RVA: 0x00208B00 File Offset: 0x00206D00
		// (set) Token: 0x0600744B RID: 29771 RVA: 0x000376F5 File Offset: 0x000358F5
		public unsafe float conveyorVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_conveyorVelocity)) = value;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600744C RID: 29772 RVA: 0x00208B28 File Offset: 0x00206D28
		// (set) Token: 0x0600744D RID: 29773 RVA: 0x00037710 File Offset: 0x00035910
		public unsafe int directionInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_directionInput)) = value;
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x00208B50 File Offset: 0x00206D50
		// (set) Token: 0x0600744F RID: 29775 RVA: 0x0003772B File Offset: 0x0003592B
		public unsafe Task task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06007450 RID: 29776 RVA: 0x00208B80 File Offset: 0x00206D80
		// (set) Token: 0x06007451 RID: 29777 RVA: 0x0003774A File Offset: 0x0003594A
		public unsafe Coroutine finalizeCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_finalizeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x00208BB0 File Offset: 0x00206DB0
		// (set) Token: 0x06007453 RID: 29779 RVA: 0x00037769 File Offset: 0x00035969
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x00208BD8 File Offset: 0x00206DD8
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x00037784 File Offset: 0x00035984
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x00208C00 File Offset: 0x00206E00
		// (set) Token: 0x06007457 RID: 29783 RVA: 0x0003779F File Offset: 0x0003599F
		public unsafe bool dropDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_dropDown)) = value;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x00208C28 File Offset: 0x00206E28
		// (set) Token: 0x06007459 RID: 29785 RVA: 0x000377BA File Offset: 0x000359BA
		public unsafe float timeSinceLastDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_timeSinceLastDrop)) = value;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x00208C50 File Offset: 0x00206E50
		// (set) Token: 0x0600745B RID: 29787 RVA: 0x000377D5 File Offset: 0x000359D5
		public unsafe bool gamepadDropButtonReleasedSinceTaskBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_gamepadDropButtonReleasedSinceTaskBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.NativeFieldInfoPtr_gamepadDropButtonReleasedSinceTaskBegin)) = value;
			}
		}

		// Token: 0x04004F03 RID: 20227
		private static readonly IntPtr NativeFieldInfoPtr__ReceiveInput_k__BackingField;

		// Token: 0x04004F04 RID: 20228
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Min;

		// Token: 0x04004F05 RID: 20229
		private static readonly IntPtr NativeFieldInfoPtr_FinalizeRange_Max;

		// Token: 0x04004F06 RID: 20230
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorSpeed;

		// Token: 0x04004F07 RID: 20231
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorAcceleration;

		// Token: 0x04004F08 RID: 20232
		private static readonly IntPtr NativeFieldInfoPtr_BaggieRadius;

		// Token: 0x04004F09 RID: 20233
		private static readonly IntPtr NativeFieldInfoPtr_JarRadius;

		// Token: 0x04004F0A RID: 20234
		private static readonly IntPtr NativeFieldInfoPtr_DeployAngle;

		// Token: 0x04004F0B RID: 20235
		private static readonly IntPtr NativeFieldInfoPtr_ProductInitialForce;

		// Token: 0x04004F0C RID: 20236
		private static readonly IntPtr NativeFieldInfoPtr_ProductRandomTorque;

		// Token: 0x04004F0D RID: 20237
		private static readonly IntPtr NativeFieldInfoPtr_KickForce;

		// Token: 0x04004F0E RID: 20238
		private static readonly IntPtr NativeFieldInfoPtr_DropCooldown;

		// Token: 0x04004F0F RID: 20239
		private static readonly IntPtr NativeFieldInfoPtr_Station;

		// Token: 0x04004F10 RID: 20240
		private static readonly IntPtr NativeFieldInfoPtr_ConveyorModel;

		// Token: 0x04004F11 RID: 20241
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04004F12 RID: 20242
		private static readonly IntPtr NativeFieldInfoPtr_CapAnim;

		// Token: 0x04004F13 RID: 20243
		private static readonly IntPtr NativeFieldInfoPtr_SealAnim;

		// Token: 0x04004F14 RID: 20244
		private static readonly IntPtr NativeFieldInfoPtr_KickAnim;

		// Token: 0x04004F15 RID: 20245
		private static readonly IntPtr NativeFieldInfoPtr_LeftButton;

		// Token: 0x04004F16 RID: 20246
		private static readonly IntPtr NativeFieldInfoPtr_RightButton;

		// Token: 0x04004F17 RID: 20247
		private static readonly IntPtr NativeFieldInfoPtr_DropButton;

		// Token: 0x04004F18 RID: 20248
		private static readonly IntPtr NativeFieldInfoPtr_PackagingContainer;

		// Token: 0x04004F19 RID: 20249
		private static readonly IntPtr NativeFieldInfoPtr_ProductCountText;

		// Token: 0x04004F1A RID: 20250
		private static readonly IntPtr NativeFieldInfoPtr_HopperDropPoint;

		// Token: 0x04004F1B RID: 20251
		private static readonly IntPtr NativeFieldInfoPtr_BaggieStartPoint;

		// Token: 0x04004F1C RID: 20252
		private static readonly IntPtr NativeFieldInfoPtr_JarStartPoint;

		// Token: 0x04004F1D RID: 20253
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x04004F1E RID: 20254
		private static readonly IntPtr NativeFieldInfoPtr_KickOrigin;

		// Token: 0x04004F1F RID: 20255
		private static readonly IntPtr NativeFieldInfoPtr_HopperInputCollider;

		// Token: 0x04004F20 RID: 20256
		private static readonly IntPtr NativeFieldInfoPtr_KickSound;

		// Token: 0x04004F21 RID: 20257
		private static readonly IntPtr NativeFieldInfoPtr_MotorSound;

		// Token: 0x04004F22 RID: 20258
		private static readonly IntPtr NativeFieldInfoPtr_DropSound;

		// Token: 0x04004F23 RID: 20259
		private static readonly IntPtr NativeFieldInfoPtr__dropAction;

		// Token: 0x04004F24 RID: 20260
		private static readonly IntPtr NativeFieldInfoPtr_PackagingPrefab;

		// Token: 0x04004F25 RID: 20261
		private static readonly IntPtr NativeFieldInfoPtr_ConcealedPackaging;

		// Token: 0x04004F26 RID: 20262
		private static readonly IntPtr NativeFieldInfoPtr_ProductItem;

		// Token: 0x04004F27 RID: 20263
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrefab;

		// Token: 0x04004F28 RID: 20264
		private static readonly IntPtr NativeFieldInfoPtr_ProductInHopper;

		// Token: 0x04004F29 RID: 20265
		private static readonly IntPtr NativeFieldInfoPtr_PackagingInstances;

		// Token: 0x04004F2A RID: 20266
		private static readonly IntPtr NativeFieldInfoPtr_ProductInstances;

		// Token: 0x04004F2B RID: 20267
		private static readonly IntPtr NativeFieldInfoPtr_FinalizedPackaging;

		// Token: 0x04004F2C RID: 20268
		private static readonly IntPtr NativeFieldInfoPtr_conveyorVelocity;

		// Token: 0x04004F2D RID: 20269
		private static readonly IntPtr NativeFieldInfoPtr_directionInput;

		// Token: 0x04004F2E RID: 20270
		private static readonly IntPtr NativeFieldInfoPtr_task;

		// Token: 0x04004F2F RID: 20271
		private static readonly IntPtr NativeFieldInfoPtr_finalizeCoroutine;

		// Token: 0x04004F30 RID: 20272
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x04004F31 RID: 20273
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x04004F32 RID: 20274
		private static readonly IntPtr NativeFieldInfoPtr_dropDown;

		// Token: 0x04004F33 RID: 20275
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrop;

		// Token: 0x04004F34 RID: 20276
		private static readonly IntPtr NativeFieldInfoPtr_gamepadDropButtonReleasedSinceTaskBegin;

		// Token: 0x04004F35 RID: 20277
		private static readonly IntPtr NativeMethodInfoPtr_get_ReceiveInput_Public_get_Boolean_0;

		// Token: 0x04004F36 RID: 20278
		private static readonly IntPtr NativeMethodInfoPtr_set_ReceiveInput_Private_set_Void_Boolean_0;

		// Token: 0x04004F37 RID: 20279
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Task_FunctionalPackaging_Int32_ProductItemInstance_Int32_0;

		// Token: 0x04004F38 RID: 20280
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Void_0;

		// Token: 0x04004F39 RID: 20281
		private static readonly IntPtr NativeMethodInfoPtr_LoadPackaging_Private_Void_FunctionalPackaging_Int32_0;

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeMethodInfoPtr_UnloadPackaging_Private_Void_0;

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeMethodInfoPtr_LoadProduct_Private_Void_ProductItemInstance_Int32_0;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeMethodInfoPtr_UnloadProduct_Private_Void_0;

		// Token: 0x04004F3D RID: 20285
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04004F3E RID: 20286
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04004F3F RID: 20287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreen_Private_Void_0;

		// Token: 0x04004F40 RID: 20288
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConveyor_Private_Void_0;

		// Token: 0x04004F41 RID: 20289
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Private_Void_Single_0;

		// Token: 0x04004F42 RID: 20290
		private static readonly IntPtr NativeMethodInfoPtr_CheckDeployPackaging_Private_Void_0;

		// Token: 0x04004F43 RID: 20291
		private static readonly IntPtr NativeMethodInfoPtr_CheckFinalize_Private_Void_0;

		// Token: 0x04004F44 RID: 20292
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Private_Void_PackagingInstance_0;

		// Token: 0x04004F45 RID: 20293
		private static readonly IntPtr NativeMethodInfoPtr_DropProduct_Private_Void_0;

		// Token: 0x04004F46 RID: 20294
		private static readonly IntPtr NativeMethodInfoPtr_CheckInsertions_Private_Void_0;

		// Token: 0x04004F47 RID: 20295
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntoHopper_Private_Void_FunctionalProduct_0;

		// Token: 0x04004F48 RID: 20296
		private static readonly IntPtr NativeMethodInfoPtr_DeployPackaging_Private_Void_0;

		// Token: 0x04004F49 RID: 20297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA6 RID: 2982
		public class PackagingInstance : Il2CppSystem.Object
		{
			// Token: 0x0600EA73 RID: 60019 RVA: 0x0038F508 File Offset: 0x0038D708
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingInstance()
			{
				Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "PackagingInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr);
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Container");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "ContainerRb");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "Packaging");
				PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, "AnglePosition");
				PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678273);
				PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr, 100678274);
			}

			// Token: 0x0600EA74 RID: 60020 RVA: 0x0038F5AC File Offset: 0x0038D7AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227809, RefRangeEnd = 227810, XrefRangeStart = 227803, XrefRangeEnd = 227809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangePosition(float angleDelta)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref angleDelta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA75 RID: 60021 RVA: 0x0038F5EC File Offset: 0x0038D7EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.PackagingInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.PackagingInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA76 RID: 60022 RVA: 0x0006E976 File Offset: 0x0006CB76
			public PackagingInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700471C RID: 18204
			// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x0038F628 File Offset: 0x0038D828
			// (set) Token: 0x0600EA78 RID: 60024 RVA: 0x0006E97F File Offset: 0x0006CB7F
			public unsafe Transform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700471D RID: 18205
			// (get) Token: 0x0600EA79 RID: 60025 RVA: 0x0038F658 File Offset: 0x0038D858
			// (set) Token: 0x0600EA7A RID: 60026 RVA: 0x0006E99E File Offset: 0x0006CB9E
			public unsafe Rigidbody ContainerRb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_ContainerRb), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700471E RID: 18206
			// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x0038F688 File Offset: 0x0038D888
			// (set) Token: 0x0600EA7C RID: 60028 RVA: 0x0006E9BD File Offset: 0x0006CBBD
			public unsafe FunctionalPackaging Packaging
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700471F RID: 18207
			// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x0038F6B8 File Offset: 0x0038D8B8
			// (set) Token: 0x0600EA7E RID: 60030 RVA: 0x0006E9DC File Offset: 0x0006CBDC
			public unsafe float AnglePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.PackagingInstance.NativeFieldInfoPtr_AnglePosition)) = value;
				}
			}

			// Token: 0x04009EE8 RID: 40680
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009EE9 RID: 40681
			private static readonly IntPtr NativeFieldInfoPtr_ContainerRb;

			// Token: 0x04009EEA RID: 40682
			private static readonly IntPtr NativeFieldInfoPtr_Packaging;

			// Token: 0x04009EEB RID: 40683
			private static readonly IntPtr NativeFieldInfoPtr_AnglePosition;

			// Token: 0x04009EEC RID: 40684
			private static readonly IntPtr NativeMethodInfoPtr_ChangePosition_Public_Void_Single_0;

			// Token: 0x04009EED RID: 40685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BA7 RID: 2983
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EA7F RID: 60031 RVA: 0x0038F6E0 File Offset: 0x0038D8E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr);
				PackagingTool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9");
				PackagingTool.__c.NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, "<>9__64_0");
				PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678276);
				PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__64_0_Internal_Int32_PackagingInstance_PackagingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr, 100678277);
			}

			// Token: 0x0600EA80 RID: 60032 RVA: 0x0038F75C File Offset: 0x0038D95C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA81 RID: 60033 RVA: 0x0038F798 File Offset: 0x0038D998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227810, XrefRangeEnd = 227812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Rotate_b__64_0(PackagingTool.PackagingInstance a, PackagingTool.PackagingInstance b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c.NativeMethodInfoPtr__Rotate_b__64_0_Internal_Int32_PackagingInstance_PackagingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA82 RID: 60034 RVA: 0x0006E9F7 File Offset: 0x0006CBF7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004720 RID: 18208
			// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x0038F7F8 File Offset: 0x0038D9F8
			// (set) Token: 0x0600EA84 RID: 60036 RVA: 0x0006EA00 File Offset: 0x0006CC00
			public unsafe static PackagingTool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004721 RID: 18209
			// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x0038F820 File Offset: 0x0038DA20
			// (set) Token: 0x0600EA86 RID: 60038 RVA: 0x0006EA12 File Offset: 0x0006CC12
			public unsafe static Comparison<PackagingTool.PackagingInstance> __9__64_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PackagingTool.__c.NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<PackagingTool.PackagingInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PackagingTool.__c.NativeFieldInfoPtr___9__64_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EEE RID: 40686
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009EEF RID: 40687
			private static readonly IntPtr NativeFieldInfoPtr___9__64_0;

			// Token: 0x04009EF0 RID: 40688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EF1 RID: 40689
			private static readonly IntPtr NativeMethodInfoPtr__Rotate_b__64_0_Internal_Int32_PackagingInstance_PackagingInstance_0;
		}

		// Token: 0x02000BA8 RID: 2984
		[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EA87 RID: 60039 RVA: 0x0038F848 File Offset: 0x0038DA48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr);
				PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr, "instance");
				PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				PackagingTool.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr, 100678278);
				PackagingTool.__c__DisplayClass67_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr, 100678279);
			}

			// Token: 0x0600EA88 RID: 60040 RVA: 0x0038F8C4 File Offset: 0x0038DAC4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA89 RID: 60041 RVA: 0x0038F900 File Offset: 0x0038DB00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227855, XrefRangeEnd = 227860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EA8A RID: 60042 RVA: 0x0006EA24 File Offset: 0x0006CC24
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004722 RID: 18210
			// (get) Token: 0x0600EA8B RID: 60043 RVA: 0x0038F940 File Offset: 0x0038DB40
			// (set) Token: 0x0600EA8C RID: 60044 RVA: 0x0006EA2D File Offset: 0x0006CC2D
			public unsafe PackagingTool.PackagingInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.PackagingInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004723 RID: 18211
			// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x0038F970 File Offset: 0x0038DB70
			// (set) Token: 0x0600EA8E RID: 60046 RVA: 0x0006EA4C File Offset: 0x0006CC4C
			public unsafe PackagingTool __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EF2 RID: 40690
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04009EF3 RID: 40691
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EF4 RID: 40692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EF5 RID: 40693
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE9 RID: 3561
			[ObfuscatedName("ScheduleOne.Packaging.PackagingTool+<>c__DisplayClass67_0+<<Finalize>g__FinalizeRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100DE RID: 65758 RVA: 0x003D025C File Offset: 0x003CE45C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0>.NativeClassPtr, "<<Finalize>g__FinalizeRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678280);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678281);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678282);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678283);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678284);
					PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678285);
				}

				// Token: 0x060100DF RID: 65759 RVA: 0x003D033C File Offset: 0x003CE53C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100E0 RID: 65760 RVA: 0x003D0384 File Offset: 0x003CE584
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100E1 RID: 65761 RVA: 0x003D03B8 File Offset: 0x003CE5B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227812, XrefRangeEnd = 227850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E4F RID: 20047
				// (get) Token: 0x060100E2 RID: 65762 RVA: 0x003D03F4 File Offset: 0x003CE5F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100E3 RID: 65763 RVA: 0x003D0434 File Offset: 0x003CE634
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227850, XrefRangeEnd = 227855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E50 RID: 20048
				// (get) Token: 0x060100E4 RID: 65764 RVA: 0x003D0468 File Offset: 0x003CE668
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100E5 RID: 65765 RVA: 0x00079C0B File Offset: 0x00077E0B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E4C RID: 20044
				// (get) Token: 0x060100E6 RID: 65766 RVA: 0x003D04A8 File Offset: 0x003CE6A8
				// (set) Token: 0x060100E7 RID: 65767 RVA: 0x00079C14 File Offset: 0x00077E14
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E4D RID: 20045
				// (get) Token: 0x060100E8 RID: 65768 RVA: 0x003D04D0 File Offset: 0x003CE6D0
				// (set) Token: 0x060100E9 RID: 65769 RVA: 0x00079C2F File Offset: 0x00077E2F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E4E RID: 20046
				// (get) Token: 0x060100EA RID: 65770 RVA: 0x003D0500 File Offset: 0x003CE700
				// (set) Token: 0x060100EB RID: 65771 RVA: 0x00079C4E File Offset: 0x00077E4E
				public unsafe PackagingTool.__c__DisplayClass67_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingTool.__c__DisplayClass67_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingTool.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ACFE RID: 44286
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACFF RID: 44287
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD00 RID: 44288
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD01 RID: 44289
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD02 RID: 44290
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD03 RID: 44291
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD04 RID: 44292
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD05 RID: 44293
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD06 RID: 44294
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
