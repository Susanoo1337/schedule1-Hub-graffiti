using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x000B80D8 File Offset: 0x000B62D8
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabase()
		{
			Il2CppClassPointerStore<VODatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabase>.NativeClassPtr);
			VODatabase.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "VolumeMultiplier");
			VODatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "Entries");
			VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100665961);
			VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100665962);
			VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100665963);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000B816C File Offset: 0x000B636C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91009, RefRangeEnd = 91012, XrefRangeStart = 90999, XrefRangeEnd = 91009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabaseEntry>(intPtr3) : null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000B81B8 File Offset: 0x000B63B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91012, XrefRangeEnd = 91013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000B8204 File Offset: 0x000B6404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91013, XrefRangeEnd = 91021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0000A375 File Offset: 0x00008575
		public VODatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000B8240 File Offset: 0x000B6440
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x0000A37E File Offset: 0x0000857E
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000B8268 File Offset: 0x000B6468
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0000A399 File Offset: 0x00008599
		public unsafe List<VODatabaseEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VODatabaseEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
