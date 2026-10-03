using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Doors;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B9 RID: 697
	public class Ladder : MonoBehaviour
	{
		// Token: 0x06003608 RID: 13832 RVA: 0x0012EF38 File Offset: 0x0012D138
		// Note: this type is marked as 'beforefieldinit'.
		static Ladder()
		{
			Il2CppClassPointerStore<Ladder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Ladder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ladder>.NativeClassPtr);
			Ladder.NativeFieldInfoPtr_NPCClimbOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "NPCClimbOffset");
			Ladder.NativeFieldInfoPtr_LadderMountDismountTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "LadderMountDismountTimeMultiplier");
			Ladder.NativeFieldInfoPtr_LadderClimbTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "LadderClimbTimeMultiplier");
			Ladder.NativeFieldInfoPtr_NPCClimbSoundInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "NPCClimbSoundInterval");
			Ladder.NativeFieldInfoPtr_PlayerClimbSoundLengthInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "PlayerClimbSoundLengthInterval");
			Ladder.NativeFieldInfoPtr_OffMeshLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "OffMeshLink");
			Ladder.NativeFieldInfoPtr_ClimbSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "ClimbSound");
			Ladder.NativeFieldInfoPtr_LinkedManholeCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "LinkedManholeCover");
			Ladder.NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "boxCollider");
			Ladder.NativeFieldInfoPtr_timeOnLastClimbSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ladder>.NativeClassPtr, "timeOnLastClimbSound");
			Ladder.NativeMethodInfoPtr_get_LadderTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670136);
			Ladder.NativeMethodInfoPtr_get_LadderSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670137);
			Ladder.NativeMethodInfoPtr_get_BottomCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670138);
			Ladder.NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670139);
			Ladder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670140);
			Ladder.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670141);
			Ladder.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670142);
			Ladder.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670143);
			Ladder.NativeMethodInfoPtr_ProjectOnLadderSurface_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670144);
			Ladder.NativeMethodInfoPtr_NormalizeProjectedPosition_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670145);
			Ladder.NativeMethodInfoPtr_PlayClimbSound_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670146);
			Ladder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ladder>.NativeClassPtr, 100670147);
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x0012F120 File Offset: 0x0012D320
		public unsafe Transform LadderTransform
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 141843, RefRangeEnd = 141854, XrefRangeStart = 141841, XrefRangeEnd = 141843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_get_LadderTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x0012F160 File Offset: 0x0012D360
		public unsafe Vector2 LadderSize
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 141860, RefRangeEnd = 141868, XrefRangeStart = 141854, XrefRangeEnd = 141860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_get_LadderSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x0012F19C File Offset: 0x0012D39C
		public unsafe Vector3 BottomCenter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 141873, RefRangeEnd = 141876, XrefRangeStart = 141868, XrefRangeEnd = 141873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_get_BottomCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x0012F1D8 File Offset: 0x0012D3D8
		public unsafe Vector3 TopCenter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 141884, RefRangeEnd = 141887, XrefRangeStart = 141876, XrefRangeEnd = 141884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x0012F214 File Offset: 0x0012D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141887, XrefRangeEnd = 141893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0012F248 File Offset: 0x0012D448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141893, XrefRangeEnd = 141916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x0012F28C File Offset: 0x0012D48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141916, XrefRangeEnd = 141939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0012F2D0 File Offset: 0x0012D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141939, XrefRangeEnd = 141967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x0012F304 File Offset: 0x0012D504
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141973, RefRangeEnd = 141976, XrefRangeStart = 141967, XrefRangeEnd = 141973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ProjectOnLadderSurface(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_ProjectOnLadderSurface_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x0012F350 File Offset: 0x0012D550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141976, XrefRangeEnd = 141980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 NormalizeProjectedPosition(Vector2 projectedPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref projectedPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_NormalizeProjectedPosition_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0012F39C File Offset: 0x0012D59C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141988, RefRangeEnd = 141991, XrefRangeStart = 141980, XrefRangeEnd = 141988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayClimbSound(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr_PlayClimbSound_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0012F3DC File Offset: 0x0012D5DC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ladder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ladder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ladder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0001B79D File Offset: 0x0001999D
		public Ladder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x0012F418 File Offset: 0x0012D618
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x0001B7A6 File Offset: 0x000199A6
		public unsafe static float NPCClimbOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ladder.NativeFieldInfoPtr_NPCClimbOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ladder.NativeFieldInfoPtr_NPCClimbOffset, (void*)(&value));
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x0012F434 File Offset: 0x0012D634
		// (set) Token: 0x06003619 RID: 13849 RVA: 0x0001B7B4 File Offset: 0x000199B4
		public unsafe static float LadderMountDismountTimeMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ladder.NativeFieldInfoPtr_LadderMountDismountTimeMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ladder.NativeFieldInfoPtr_LadderMountDismountTimeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x0012F450 File Offset: 0x0012D650
		// (set) Token: 0x0600361B RID: 13851 RVA: 0x0001B7C2 File Offset: 0x000199C2
		public unsafe static float LadderClimbTimeMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ladder.NativeFieldInfoPtr_LadderClimbTimeMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ladder.NativeFieldInfoPtr_LadderClimbTimeMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x0012F46C File Offset: 0x0012D66C
		// (set) Token: 0x0600361D RID: 13853 RVA: 0x0001B7D0 File Offset: 0x000199D0
		public unsafe static float NPCClimbSoundInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ladder.NativeFieldInfoPtr_NPCClimbSoundInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ladder.NativeFieldInfoPtr_NPCClimbSoundInterval, (void*)(&value));
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x0012F488 File Offset: 0x0012D688
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x0001B7DE File Offset: 0x000199DE
		public unsafe static float PlayerClimbSoundLengthInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Ladder.NativeFieldInfoPtr_PlayerClimbSoundLengthInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Ladder.NativeFieldInfoPtr_PlayerClimbSoundLengthInterval, (void*)(&value));
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x0012F4A4 File Offset: 0x0012D6A4
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x0001B7EC File Offset: 0x000199EC
		public unsafe OffMeshLink OffMeshLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_OffMeshLink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OffMeshLink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_OffMeshLink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x0012F4D4 File Offset: 0x0012D6D4
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x0001B80B File Offset: 0x00019A0B
		public unsafe AudioSourceController ClimbSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_ClimbSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_ClimbSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x0012F504 File Offset: 0x0012D704
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x0001B82A File Offset: 0x00019A2A
		public unsafe SewerDoorController LinkedManholeCover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_LinkedManholeCover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerDoorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_LinkedManholeCover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x0012F534 File Offset: 0x0012D734
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x0001B849 File Offset: 0x00019A49
		public unsafe BoxCollider boxCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_boxCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x0012F564 File Offset: 0x0012D764
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x0001B868 File Offset: 0x00019A68
		public unsafe float timeOnLastClimbSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_timeOnLastClimbSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ladder.NativeFieldInfoPtr_timeOnLastClimbSound)) = value;
			}
		}

		// Token: 0x0400242F RID: 9263
		private static readonly IntPtr NativeFieldInfoPtr_NPCClimbOffset;

		// Token: 0x04002430 RID: 9264
		private static readonly IntPtr NativeFieldInfoPtr_LadderMountDismountTimeMultiplier;

		// Token: 0x04002431 RID: 9265
		private static readonly IntPtr NativeFieldInfoPtr_LadderClimbTimeMultiplier;

		// Token: 0x04002432 RID: 9266
		private static readonly IntPtr NativeFieldInfoPtr_NPCClimbSoundInterval;

		// Token: 0x04002433 RID: 9267
		private static readonly IntPtr NativeFieldInfoPtr_PlayerClimbSoundLengthInterval;

		// Token: 0x04002434 RID: 9268
		private static readonly IntPtr NativeFieldInfoPtr_OffMeshLink;

		// Token: 0x04002435 RID: 9269
		private static readonly IntPtr NativeFieldInfoPtr_ClimbSound;

		// Token: 0x04002436 RID: 9270
		private static readonly IntPtr NativeFieldInfoPtr_LinkedManholeCover;

		// Token: 0x04002437 RID: 9271
		private static readonly IntPtr NativeFieldInfoPtr_boxCollider;

		// Token: 0x04002438 RID: 9272
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastClimbSound;

		// Token: 0x04002439 RID: 9273
		private static readonly IntPtr NativeMethodInfoPtr_get_LadderTransform_Public_get_Transform_0;

		// Token: 0x0400243A RID: 9274
		private static readonly IntPtr NativeMethodInfoPtr_get_LadderSize_Public_get_Vector2_0;

		// Token: 0x0400243B RID: 9275
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomCenter_Public_get_Vector3_0;

		// Token: 0x0400243C RID: 9276
		private static readonly IntPtr NativeMethodInfoPtr_get_TopCenter_Public_get_Vector3_0;

		// Token: 0x0400243D RID: 9277
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400243E RID: 9278
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x0400243F RID: 9279
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04002440 RID: 9280
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002441 RID: 9281
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnLadderSurface_Public_Vector2_Vector3_0;

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeProjectedPosition_Public_Vector2_Vector2_0;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeMethodInfoPtr_PlayClimbSound_Public_Void_Vector3_0;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
