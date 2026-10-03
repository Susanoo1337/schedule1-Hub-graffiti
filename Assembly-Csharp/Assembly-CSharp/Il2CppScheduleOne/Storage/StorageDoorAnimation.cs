using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000534 RID: 1332
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x06007919 RID: 31001 RVA: 0x00219CF8 File Offset: 0x00217EF8
		// Note: this type is marked as 'beforefieldinit'.
		static StorageDoorAnimation()
		{
			Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageDoorAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr);
			StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overriddeIsOpen");
			StorageDoorAnimation.NativeFieldInfoPtr_overrideState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "overrideState");
			StorageDoorAnimation.NativeFieldInfoPtr__disableItemContainerWhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "_disableItemContainerWhenClosed");
			StorageDoorAnimation.NativeFieldInfoPtr_Anims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "Anims");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseAnim");
			StorageDoorAnimation.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "OpenSound");
			StorageDoorAnimation.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "CloseSound");
			StorageDoorAnimation.NativeFieldInfoPtr_storageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "storageEntity");
			StorageDoorAnimation.NativeFieldInfoPtr_itemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, "itemContainer");
			StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678877);
			StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678878);
			StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678879);
			StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678880);
			StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678881);
			StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678882);
			StorageDoorAnimation.NativeMethodInfoPtr_RefreshItemsVisible_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678883);
			StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678884);
			StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678885);
			StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr, 100678886);
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x00219ECC File Offset: 0x002180CC
		// (set) Token: 0x0600791B RID: 31003 RVA: 0x00219F08 File Offset: 0x00218108
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00219F48 File Offset: 0x00218148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233553, XrefRangeEnd = 233591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00219F7C File Offset: 0x0021817C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233591, XrefRangeEnd = 233592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00219FB0 File Offset: 0x002181B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233592, XrefRangeEnd = 233593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00219FE4 File Offset: 0x002181E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 233608, RefRangeEnd = 233616, XrefRangeStart = 233593, XrefRangeEnd = 233608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x0021A024 File Offset: 0x00218224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233616, XrefRangeEnd = 233623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshItemsVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageDoorAnimation.NativeMethodInfoPtr_RefreshItemsVisible_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x0021A060 File Offset: 0x00218260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233624, RefRangeEnd = 233625, XrefRangeStart = 233623, XrefRangeEnd = 233624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideState(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x0021A0A0 File Offset: 0x002182A0
		[CallerCount(0)]
		public unsafe void ResetOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr_ResetOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x0021A0D4 File Offset: 0x002182D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233625, XrefRangeEnd = 233626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageDoorAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageDoorAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageDoorAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x000399ED File Offset: 0x00037BED
		public StorageDoorAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06007925 RID: 31013 RVA: 0x0021A110 File Offset: 0x00218310
		// (set) Token: 0x06007926 RID: 31014 RVA: 0x000399F6 File Offset: 0x00037BF6
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x0021A138 File Offset: 0x00218338
		// (set) Token: 0x06007928 RID: 31016 RVA: 0x00039A11 File Offset: 0x00037C11
		public unsafe bool overriddeIsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overriddeIsOpen)) = value;
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x0021A160 File Offset: 0x00218360
		// (set) Token: 0x0600792A RID: 31018 RVA: 0x00039A2C File Offset: 0x00037C2C
		public unsafe bool overrideState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_overrideState)) = value;
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x0600792B RID: 31019 RVA: 0x0021A188 File Offset: 0x00218388
		// (set) Token: 0x0600792C RID: 31020 RVA: 0x00039A47 File Offset: 0x00037C47
		public unsafe bool _disableItemContainerWhenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__disableItemContainerWhenClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr__disableItemContainerWhenClosed)) = value;
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x0600792D RID: 31021 RVA: 0x0021A1B0 File Offset: 0x002183B0
		// (set) Token: 0x0600792E RID: 31022 RVA: 0x00039A62 File Offset: 0x00037C62
		public unsafe Il2CppReferenceArray<Animation> Anims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Animation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_Anims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x0600792F RID: 31023 RVA: 0x0021A1E0 File Offset: 0x002183E0
		// (set) Token: 0x06007930 RID: 31024 RVA: 0x00039A81 File Offset: 0x00037C81
		public unsafe AnimationClip OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06007931 RID: 31025 RVA: 0x0021A210 File Offset: 0x00218410
		// (set) Token: 0x06007932 RID: 31026 RVA: 0x00039AA0 File Offset: 0x00037CA0
		public unsafe AnimationClip CloseAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06007933 RID: 31027 RVA: 0x0021A240 File Offset: 0x00218440
		// (set) Token: 0x06007934 RID: 31028 RVA: 0x00039ABF File Offset: 0x00037CBF
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06007935 RID: 31029 RVA: 0x0021A270 File Offset: 0x00218470
		// (set) Token: 0x06007936 RID: 31030 RVA: 0x00039ADE File Offset: 0x00037CDE
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06007937 RID: 31031 RVA: 0x0021A2A0 File Offset: 0x002184A0
		// (set) Token: 0x06007938 RID: 31032 RVA: 0x00039AFD File Offset: 0x00037CFD
		public unsafe StorageEntity storageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_storageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_storageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06007939 RID: 31033 RVA: 0x0021A2D0 File Offset: 0x002184D0
		// (set) Token: 0x0600793A RID: 31034 RVA: 0x00039B1C File Offset: 0x00037D1C
		public unsafe Transform itemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_itemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageDoorAnimation.NativeFieldInfoPtr_itemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400528D RID: 21133
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400528E RID: 21134
		private static readonly IntPtr NativeFieldInfoPtr_overriddeIsOpen;

		// Token: 0x0400528F RID: 21135
		private static readonly IntPtr NativeFieldInfoPtr_overrideState;

		// Token: 0x04005290 RID: 21136
		private static readonly IntPtr NativeFieldInfoPtr__disableItemContainerWhenClosed;

		// Token: 0x04005291 RID: 21137
		private static readonly IntPtr NativeFieldInfoPtr_Anims;

		// Token: 0x04005292 RID: 21138
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x04005293 RID: 21139
		private static readonly IntPtr NativeFieldInfoPtr_CloseAnim;

		// Token: 0x04005294 RID: 21140
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04005295 RID: 21141
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04005296 RID: 21142
		private static readonly IntPtr NativeFieldInfoPtr_storageEntity;

		// Token: 0x04005297 RID: 21143
		private static readonly IntPtr NativeFieldInfoPtr_itemContainer;

		// Token: 0x04005298 RID: 21144
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005299 RID: 21145
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400529A RID: 21146
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400529B RID: 21147
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400529C RID: 21148
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400529D RID: 21149
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400529E RID: 21150
		private static readonly IntPtr NativeMethodInfoPtr_RefreshItemsVisible_Protected_Virtual_New_Void_0;

		// Token: 0x0400529F RID: 21151
		private static readonly IntPtr NativeMethodInfoPtr_OverrideState_Public_Void_Boolean_0;

		// Token: 0x040052A0 RID: 21152
		private static readonly IntPtr NativeMethodInfoPtr_ResetOverride_Public_Void_0;

		// Token: 0x040052A1 RID: 21153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
