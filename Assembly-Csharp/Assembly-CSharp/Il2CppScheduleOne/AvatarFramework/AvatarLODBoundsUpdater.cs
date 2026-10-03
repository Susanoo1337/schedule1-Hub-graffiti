using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000497 RID: 1175
	public class AvatarLODBoundsUpdater : MonoBehaviour
	{
		// Token: 0x06006B30 RID: 27440 RVA: 0x001EE564 File Offset: 0x001EC764
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLODBoundsUpdater()
		{
			Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarLODBoundsUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr);
			AvatarLODBoundsUpdater.NativeFieldInfoPtr_CHECK_RATE_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, "CHECK_RATE_SECONDS");
			AvatarLODBoundsUpdater.NativeFieldInfoPtr_HIP_OFFSET_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, "HIP_OFFSET_THRESHOLD");
			AvatarLODBoundsUpdater.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, "Avatar");
			AvatarLODBoundsUpdater.NativeFieldInfoPtr_lodGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, "lodGroups");
			AvatarLODBoundsUpdater.NativeFieldInfoPtr_hipOffsetOnLastRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, "hipOffsetOnLastRefresh");
			AvatarLODBoundsUpdater.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677319);
			AvatarLODBoundsUpdater.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677320);
			AvatarLODBoundsUpdater.NativeMethodInfoPtr_GetLODGroups_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677321);
			AvatarLODBoundsUpdater.NativeMethodInfoPtr_Recalculate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677322);
			AvatarLODBoundsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677323);
			AvatarLODBoundsUpdater.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr, 100677324);
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x001EE670 File Offset: 0x001EC870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220420, XrefRangeEnd = 220447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x001EE6A4 File Offset: 0x001EC8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220447, XrefRangeEnd = 220456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x001EE6D8 File Offset: 0x001EC8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220456, XrefRangeEnd = 220464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLODGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr_GetLODGroups_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x001EE70C File Offset: 0x001EC90C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 220488, RefRangeEnd = 220490, XrefRangeStart = 220464, XrefRangeEnd = 220488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr_Recalculate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x001EE740 File Offset: 0x001EC940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220490, XrefRangeEnd = 220493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLODBoundsUpdater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLODBoundsUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x001EE77C File Offset: 0x001EC97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220493, XrefRangeEnd = 220494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0(bool x, bool y, bool z)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLODBoundsUpdater.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x000327BF File Offset: 0x000309BF
		public AvatarLODBoundsUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x001EE7D8 File Offset: 0x001EC9D8
		// (set) Token: 0x06006B39 RID: 27449 RVA: 0x000327C8 File Offset: 0x000309C8
		public unsafe static float CHECK_RATE_SECONDS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLODBoundsUpdater.NativeFieldInfoPtr_CHECK_RATE_SECONDS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLODBoundsUpdater.NativeFieldInfoPtr_CHECK_RATE_SECONDS, (void*)(&value));
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06006B3A RID: 27450 RVA: 0x001EE7F4 File Offset: 0x001EC9F4
		// (set) Token: 0x06006B3B RID: 27451 RVA: 0x000327D6 File Offset: 0x000309D6
		public unsafe static float HIP_OFFSET_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLODBoundsUpdater.NativeFieldInfoPtr_HIP_OFFSET_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLODBoundsUpdater.NativeFieldInfoPtr_HIP_OFFSET_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06006B3C RID: 27452 RVA: 0x001EE810 File Offset: 0x001ECA10
		// (set) Token: 0x06006B3D RID: 27453 RVA: 0x000327E4 File Offset: 0x000309E4
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06006B3E RID: 27454 RVA: 0x001EE840 File Offset: 0x001ECA40
		// (set) Token: 0x06006B3F RID: 27455 RVA: 0x00032803 File Offset: 0x00030A03
		public unsafe List<LODGroup> lodGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_lodGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LODGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_lodGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06006B40 RID: 27456 RVA: 0x001EE870 File Offset: 0x001ECA70
		// (set) Token: 0x06006B41 RID: 27457 RVA: 0x00032822 File Offset: 0x00030A22
		public unsafe Vector3 hipOffsetOnLastRefresh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_hipOffsetOnLastRefresh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLODBoundsUpdater.NativeFieldInfoPtr_hipOffsetOnLastRefresh)) = value;
			}
		}

		// Token: 0x040049BB RID: 18875
		private static readonly IntPtr NativeFieldInfoPtr_CHECK_RATE_SECONDS;

		// Token: 0x040049BC RID: 18876
		private static readonly IntPtr NativeFieldInfoPtr_HIP_OFFSET_THRESHOLD;

		// Token: 0x040049BD RID: 18877
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040049BE RID: 18878
		private static readonly IntPtr NativeFieldInfoPtr_lodGroups;

		// Token: 0x040049BF RID: 18879
		private static readonly IntPtr NativeFieldInfoPtr_hipOffsetOnLastRefresh;

		// Token: 0x040049C0 RID: 18880
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040049C1 RID: 18881
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x040049C2 RID: 18882
		private static readonly IntPtr NativeMethodInfoPtr_GetLODGroups_Private_Void_0;

		// Token: 0x040049C3 RID: 18883
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Private_Void_0;

		// Token: 0x040049C4 RID: 18884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049C5 RID: 18885
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Boolean_Boolean_Boolean_0;
	}
}
