using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200017A RID: 378
	public class SpawnChunk : Clickable
	{
		// Token: 0x06002649 RID: 9801 RVA: 0x000F9B00 File Offset: 0x000F7D00
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnChunk()
		{
			Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "SpawnChunk");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr);
			SpawnChunk.NativeFieldInfoPtr__meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "_meshRenderer");
			SpawnChunk.NativeFieldInfoPtr__rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "_rb");
			SpawnChunk.NativeFieldInfoPtr__collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "_collider");
			SpawnChunk.NativeFieldInfoPtr__isBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "_isBroken");
			SpawnChunk.NativeFieldInfoPtr__childChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "_childChunks");
			SpawnChunk.NativeFieldInfoPtr_OnBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, "OnBreak");
			SpawnChunk.NativeMethodInfoPtr_get_hasChildChunks_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668224);
			SpawnChunk.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668225);
			SpawnChunk.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668226);
			SpawnChunk.NativeMethodInfoPtr_EnableChunk_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668227);
			SpawnChunk.NativeMethodInfoPtr_DisableChunk_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668228);
			SpawnChunk.NativeMethodInfoPtr_Break_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668229);
			SpawnChunk.NativeMethodInfoPtr_GetIsBroken_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668230);
			SpawnChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668231);
			SpawnChunk.NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668232);
			SpawnChunk.NativeMethodInfoPtr_SetChunkOrder_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668233);
			SpawnChunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr, 100668234);
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x000F9C84 File Offset: 0x000F7E84
		public unsafe bool hasChildChunks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117431, XrefRangeEnd = 117432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_get_hasChildChunks_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000F9CC0 File Offset: 0x000F7EC0
		public unsafe override bool RegisterDefaultLureWhenEmpty
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnChunk.NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000F9D08 File Offset: 0x000F7F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117432, XrefRangeEnd = 117456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000F9D3C File Offset: 0x000F7F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117473, RefRangeEnd = 117475, XrefRangeStart = 117456, XrefRangeEnd = 117473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableChunk(Vector3 force, Vector3 torque)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref torque;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_EnableChunk_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000F9D88 File Offset: 0x000F7F88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117496, RefRangeEnd = 117499, XrefRangeStart = 117475, XrefRangeEnd = 117496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableChunk(bool recursive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_DisableChunk_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000F9DC8 File Offset: 0x000F7FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117523, RefRangeEnd = 117524, XrefRangeStart = 117499, XrefRangeEnd = 117523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_Break_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000F9DFC File Offset: 0x000F7FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117535, RefRangeEnd = 117536, XrefRangeStart = 117524, XrefRangeEnd = 117535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsBroken(bool recursive = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_GetIsBroken_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000F9E48 File Offset: 0x000F8048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117536, XrefRangeEnd = 117543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartClick(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnChunk.NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000F9E94 File Offset: 0x000F8094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117559, RefRangeEnd = 117560, XrefRangeStart = 117543, XrefRangeEnd = 117559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000F9EC8 File Offset: 0x000F80C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117579, RefRangeEnd = 117581, XrefRangeStart = 117560, XrefRangeEnd = 117579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChunkOrder(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr_SetChunkOrder_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000F9F08 File Offset: 0x000F8108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117581, XrefRangeEnd = 117591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnChunk() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChunk>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnChunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x0001432D File Offset: 0x0001252D
		public SpawnChunk(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x000F9F44 File Offset: 0x000F8144
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00014336 File Offset: 0x00012536
		public unsafe MeshRenderer _meshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__meshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000F9F74 File Offset: 0x000F8174
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x00014355 File Offset: 0x00012555
		public unsafe Rigidbody _rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x000F9FA4 File Offset: 0x000F81A4
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x00014374 File Offset: 0x00012574
		public unsafe Collider _collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000F9FD4 File Offset: 0x000F81D4
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x00014393 File Offset: 0x00012593
		public unsafe bool _isBroken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__isBroken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__isBroken)) = value;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000F9FFC File Offset: 0x000F81FC
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x000143AE File Offset: 0x000125AE
		public unsafe List<SpawnChunk> _childChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__childChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpawnChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr__childChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x000FA02C File Offset: 0x000F822C
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x000143CD File Offset: 0x000125CD
		public unsafe UnityEvent OnBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr_OnBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnChunk.NativeFieldInfoPtr_OnBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderer;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeFieldInfoPtr__rb;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeFieldInfoPtr__collider;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeFieldInfoPtr__isBroken;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeFieldInfoPtr__childChunks;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeFieldInfoPtr_OnBreak;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChildChunks_Private_get_Boolean_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisterDefaultLureWhenEmpty_Public_Virtual_get_Boolean_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_EnableChunk_Public_Void_Vector3_Vector3_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_DisableChunk_Public_Void_Boolean_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_Break_Public_Void_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_GetIsBroken_Public_Boolean_Boolean_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_StartClick_Public_Virtual_Void_RaycastHit_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_SetChunkOrder_Public_Void_Int32_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
