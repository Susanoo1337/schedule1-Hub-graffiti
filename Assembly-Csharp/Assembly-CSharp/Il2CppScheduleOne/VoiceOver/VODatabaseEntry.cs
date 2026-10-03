using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	public class VODatabaseEntry : Il2CppSystem.Object
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x000B8298 File Offset: 0x000B6498
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabaseEntry()
		{
			Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabaseEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr);
			VODatabaseEntry.NativeFieldInfoPtr_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "LineType");
			VODatabaseEntry.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "Clips");
			VODatabaseEntry.NativeFieldInfoPtr_lastClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "lastClip");
			VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "VolumeMultiplier");
			VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100665964);
			VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100665965);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000B8340 File Offset: 0x000B6540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91021, XrefRangeEnd = 91029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000B8380 File Offset: 0x000B6580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91029, XrefRangeEnd = 91030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0000A3B8 File Offset: 0x000085B8
		public VODatabaseEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000B83BC File Offset: 0x000B65BC
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x0000A3C1 File Offset: 0x000085C1
		public unsafe EVOLineType LineType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000B83E4 File Offset: 0x000B65E4
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x0000A3DC File Offset: 0x000085DC
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x000B8414 File Offset: 0x000B6614
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x0000A3FB File Offset: 0x000085FB
		public unsafe AudioClip lastClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000B8444 File Offset: 0x000B6644
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x0000A41A File Offset: 0x0000861A
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_LineType;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr_lastClip;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
