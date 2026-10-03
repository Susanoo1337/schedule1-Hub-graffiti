using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000194 RID: 404
	public class PlayerVisibility : EntityVisibility
	{
		// Token: 0x060028E5 RID: 10469 RVA: 0x0010228C File Offset: 0x0010048C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisibility()
		{
			Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "PlayerVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr);
			PlayerVisibility.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "player");
			PlayerVisibility.NativeFieldInfoPtr_disobeyingCurfewStateApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "disobeyingCurfewStateApplied");
			PlayerVisibility.NativeFieldInfoPtr__cachedVisibilityPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "_cachedVisibilityPoints");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vision.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vision.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668522);
			PlayerVisibility.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668523);
			PlayerVisibility.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668524);
			PlayerVisibility.NativeMethodInfoPtr_AddFlag_DisobeyingCurfew_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668525);
			PlayerVisibility.NativeMethodInfoPtr_RemoveFlag_DisobeyingCurfew_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668526);
			PlayerVisibility.NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668527);
			PlayerVisibility.NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668528);
			PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668529);
			PlayerVisibility.NativeMethodInfoPtr__Awake_b__3_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668530);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668531);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668532);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668533);
			PlayerVisibility.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100668534);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x00102424 File Offset: 0x00100624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122007, XrefRangeEnd = 122023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00102460 File Offset: 0x00100660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122023, XrefRangeEnd = 122034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00102494 File Offset: 0x00100694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122034, XrefRangeEnd = 122056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x001024C8 File Offset: 0x001006C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122056, XrefRangeEnd = 122060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFlag_DisobeyingCurfew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_AddFlag_DisobeyingCurfew_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x001024FC File Offset: 0x001006FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122060, XrefRangeEnd = 122064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFlag_DisobeyingCurfew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_RemoveFlag_DisobeyingCurfew_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x00102530 File Offset: 0x00100730
		public unsafe override float Suspiciousness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122064, XrefRangeEnd = 122074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00102578 File Offset: 0x00100778
		[CallerCount(0)]
		public unsafe override List<Vector3> GetVisibilityPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_List_1_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x001025C4 File Offset: 0x001007C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122074, XrefRangeEnd = 122117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00102600 File Offset: 0x00100800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122126, RefRangeEnd = 122129, XrefRangeStart = 122117, XrefRangeEnd = 122126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr__Awake_b__3_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00102634 File Offset: 0x00100834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122129, XrefRangeEnd = 122142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00102670 File Offset: 0x00100870
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x001026AC File Offset: 0x001008AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x001026E8 File Offset: 0x001008E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122142, XrefRangeEnd = 122157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00015760 File Offset: 0x00013960
		public PlayerVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x00102724 File Offset: 0x00100924
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x00015769 File Offset: 0x00013969
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x00102754 File Offset: 0x00100954
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x00015788 File Offset: 0x00013988
		public unsafe bool disobeyingCurfewStateApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_disobeyingCurfewStateApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_disobeyingCurfewStateApplied)) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x0010277C File Offset: 0x0010097C
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x000157A3 File Offset: 0x000139A3
		public unsafe List<Vector3> _cachedVisibilityPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__cachedVisibilityPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__cachedVisibilityPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060028FA RID: 10490 RVA: 0x001027AC File Offset: 0x001009AC
		// (set) Token: 0x060028FB RID: 10491 RVA: 0x000157C2 File Offset: 0x000139C2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x001027D4 File Offset: 0x001009D4
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x000157DD File Offset: 0x000139DD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeFieldInfoPtr_disobeyingCurfewStateApplied;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeFieldInfoPtr__cachedVisibilityPoints;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_AddFlag_DisobeyingCurfew_Private_Void_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFlag_DisobeyingCurfew_Private_Void_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeMethodInfoPtr_get_Suspiciousness_Public_Virtual_get_Single_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibilityPoints_Protected_Virtual_List_1_Vector3_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__3_0_Private_Void_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000995 RID: 2453
		[ObfuscatedName("ScheduleOne.Vision.PlayerVisibility+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA7E RID: 55934 RVA: 0x00362968 File Offset: 0x00360B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr);
				PlayerVisibility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__5_0");
				PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100668536);
				PlayerVisibility.__c.NativeMethodInfoPtr__LateUpdate_b__5_0_Internal_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100668537);
			}

			// Token: 0x0600DA7F RID: 55935 RVA: 0x003629E4 File Offset: 0x00360BE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA80 RID: 55936 RVA: 0x00362A20 File Offset: 0x00360C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122006, XrefRangeEnd = 122007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _LateUpdate_b__5_0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__LateUpdate_b__5_0_Internal_Vector3_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA81 RID: 55937 RVA: 0x00066BA0 File Offset: 0x00064DA0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B7 RID: 17079
			// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x00362A70 File Offset: 0x00360C70
			// (set) Token: 0x0600DA83 RID: 55939 RVA: 0x00066BA9 File Offset: 0x00064DA9
			public unsafe static PlayerVisibility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B8 RID: 17080
			// (get) Token: 0x0600DA84 RID: 55940 RVA: 0x00362A98 File Offset: 0x00360C98
			// (set) Token: 0x0600DA85 RID: 55941 RVA: 0x00066BBB File Offset: 0x00064DBB
			public unsafe static Func<Transform, Vector3> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400953E RID: 38206
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400953F RID: 38207
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04009540 RID: 38208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009541 RID: 38209
			private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__5_0_Internal_Vector3_Transform_0;
		}
	}
}
