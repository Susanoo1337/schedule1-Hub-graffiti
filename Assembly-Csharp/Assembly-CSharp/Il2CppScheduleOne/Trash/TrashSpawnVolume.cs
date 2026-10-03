using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000492 RID: 1170
	public class TrashSpawnVolume : MonoBehaviour
	{
		// Token: 0x060069EF RID: 27119 RVA: 0x001EA654 File Offset: 0x001E8854
		// Note: this type is marked as 'beforefieldinit'.
		static TrashSpawnVolume()
		{
			Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashSpawnVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr);
			TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "CreatonVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "DetectionVolume");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashLimit");
			TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, "TrashSpawnChance");
			TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100677188);
			TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100677189);
			TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100677190);
			TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr, 100677191);
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x001EA724 File Offset: 0x001E8924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218794, XrefRangeEnd = 218812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x001EA758 File Offset: 0x001E8958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218812, XrefRangeEnd = 218830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x001EA78C File Offset: 0x001E898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218830, XrefRangeEnd = 218909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x001EA7C0 File Offset: 0x001E89C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218909, XrefRangeEnd = 218910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashSpawnVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashSpawnVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashSpawnVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00031BB3 File Offset: 0x0002FDB3
		public TrashSpawnVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x060069F5 RID: 27125 RVA: 0x001EA7FC File Offset: 0x001E89FC
		// (set) Token: 0x060069F6 RID: 27126 RVA: 0x00031BBC File Offset: 0x0002FDBC
		public unsafe BoxCollider CreatonVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_CreatonVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x060069F7 RID: 27127 RVA: 0x001EA82C File Offset: 0x001E8A2C
		// (set) Token: 0x060069F8 RID: 27128 RVA: 0x00031BDB File Offset: 0x0002FDDB
		public unsafe BoxCollider DetectionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_DetectionVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x060069F9 RID: 27129 RVA: 0x001EA85C File Offset: 0x001E8A5C
		// (set) Token: 0x060069FA RID: 27130 RVA: 0x00031BFA File Offset: 0x0002FDFA
		public unsafe int TrashLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashLimit)) = value;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x060069FB RID: 27131 RVA: 0x001EA884 File Offset: 0x001E8A84
		// (set) Token: 0x060069FC RID: 27132 RVA: 0x00031C15 File Offset: 0x0002FE15
		public unsafe float TrashSpawnChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashSpawnVolume.NativeFieldInfoPtr_TrashSpawnChance)) = value;
			}
		}

		// Token: 0x040048EC RID: 18668
		private static readonly IntPtr NativeFieldInfoPtr_CreatonVolume;

		// Token: 0x040048ED RID: 18669
		private static readonly IntPtr NativeFieldInfoPtr_DetectionVolume;

		// Token: 0x040048EE RID: 18670
		private static readonly IntPtr NativeFieldInfoPtr_TrashLimit;

		// Token: 0x040048EF RID: 18671
		private static readonly IntPtr NativeFieldInfoPtr_TrashSpawnChance;

		// Token: 0x040048F0 RID: 18672
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040048F1 RID: 18673
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040048F2 RID: 18674
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x040048F3 RID: 18675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
