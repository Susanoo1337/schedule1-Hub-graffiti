using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000491 RID: 1169
	public class TrashRemovalVolume : MonoBehaviour
	{
		// Token: 0x060069E4 RID: 27108 RVA: 0x001EA428 File Offset: 0x001E8628
		// Note: this type is marked as 'beforefieldinit'.
		static TrashRemovalVolume()
		{
			Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashRemovalVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr);
			TrashRemovalVolume.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "Collider");
			TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, "RemovalChance");
			TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100677183);
			TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100677184);
			TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100677185);
			TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100677186);
			TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr, 100677187);
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x001EA4E4 File Offset: 0x001E86E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218714, XrefRangeEnd = 218732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x001EA518 File Offset: 0x001E8718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218732, XrefRangeEnd = 218750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x001EA54C File Offset: 0x001E874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218750, XrefRangeEnd = 218755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x001EA580 File Offset: 0x001E8780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218792, RefRangeEnd = 218793, XrefRangeStart = 218755, XrefRangeEnd = 218792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x001EA5C0 File Offset: 0x001E87C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218793, XrefRangeEnd = 218794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashRemovalVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashRemovalVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashRemovalVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00031B70 File Offset: 0x0002FD70
		public TrashRemovalVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x001EA5FC File Offset: 0x001E87FC
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x00031B79 File Offset: 0x0002FD79
		public unsafe BoxCollider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x001EA62C File Offset: 0x001E882C
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x00031B98 File Offset: 0x0002FD98
		public unsafe float RemovalChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashRemovalVolume.NativeFieldInfoPtr_RemovalChance)) = value;
			}
		}

		// Token: 0x040048E5 RID: 18661
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x040048E6 RID: 18662
		private static readonly IntPtr NativeFieldInfoPtr_RemovalChance;

		// Token: 0x040048E7 RID: 18663
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040048E8 RID: 18664
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040048E9 RID: 18665
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x040048EA RID: 18666
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x040048EB RID: 18667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
