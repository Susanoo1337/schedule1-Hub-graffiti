using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BE RID: 1214
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x06006F6E RID: 28526 RVA: 0x001FA808 File Offset: 0x001F8A08
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeat()
		{
			Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr);
			AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "<Occupant>k__BackingField");
			AvatarSeat.NativeFieldInfoPtr_SittingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "SittingPoint");
			AvatarSeat.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, "AccessPoint");
			AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677734);
			AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677735);
			AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677736);
			AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677737);
			AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677738);
			AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr, 100677739);
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06006F6F RID: 28527 RVA: 0x001FA8EC File Offset: 0x001F8AEC
		public unsafe bool IsOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223737, XrefRangeEnd = 223741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x001FA928 File Offset: 0x001F8B28
		// (set) Token: 0x06006F71 RID: 28529 RVA: 0x001FA968 File Offset: 0x001F8B68
		public unsafe NPC Occupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x001FA9AC File Offset: 0x001F8BAC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x001FA9E0 File Offset: 0x001F8BE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223756, RefRangeEnd = 223759, XrefRangeStart = 223741, XrefRangeEnd = 223756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x001FAA24 File Offset: 0x001F8C24
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x00034D82 File Offset: 0x00032F82
		public AvatarSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x001FAA60 File Offset: 0x001F8C60
		// (set) Token: 0x06006F77 RID: 28535 RVA: 0x00034D8B File Offset: 0x00032F8B
		public unsafe NPC _Occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr__Occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x001FAA90 File Offset: 0x001F8C90
		// (set) Token: 0x06006F79 RID: 28537 RVA: 0x00034DAA File Offset: 0x00032FAA
		public unsafe Transform SittingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_SittingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x001FAAC0 File Offset: 0x001F8CC0
		// (set) Token: 0x06006F7B RID: 28539 RVA: 0x00034DC9 File Offset: 0x00032FC9
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeat.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C53 RID: 19539
		private static readonly IntPtr NativeFieldInfoPtr__Occupant_k__BackingField;

		// Token: 0x04004C54 RID: 19540
		private static readonly IntPtr NativeFieldInfoPtr_SittingPoint;

		// Token: 0x04004C55 RID: 19541
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04004C56 RID: 19542
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04004C57 RID: 19543
		private static readonly IntPtr NativeMethodInfoPtr_get_Occupant_Public_get_NPC_0;

		// Token: 0x04004C58 RID: 19544
		private static readonly IntPtr NativeMethodInfoPtr_set_Occupant_Protected_set_Void_NPC_0;

		// Token: 0x04004C59 RID: 19545
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004C5A RID: 19546
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_NPC_0;

		// Token: 0x04004C5B RID: 19547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
