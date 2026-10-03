using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FC RID: 1532
	[Serializable]
	public class Voice : Object
	{
		// Token: 0x0600959F RID: 38303 RVA: 0x00285650 File Offset: 0x00283850
		// Note: this type is marked as 'beforefieldinit'.
		static Voice()
		{
			Il2CppClassPointerStore<Voice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Voice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Voice>.NativeClassPtr);
			Voice.NativeFieldInfoPtr_VoiceDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voice>.NativeClassPtr, "VoiceDatabase");
			Voice.NativeFieldInfoPtr_VoicePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Voice>.NativeClassPtr, "VoicePitch");
			Voice.NativeMethodInfoPtr_GetCopy_Public_Voice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voice>.NativeClassPtr, 100682834);
			Voice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Voice>.NativeClassPtr, 100682835);
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x002856D0 File Offset: 0x002838D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272309, XrefRangeEnd = 272314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Voice GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Voice.NativeMethodInfoPtr_GetCopy_Public_Voice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Voice>(intPtr3) : null;
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x00285710 File Offset: 0x00283910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Voice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Voice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Voice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x0004602F File Offset: 0x0004422F
		public Voice(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x0028574C File Offset: 0x0028394C
		// (set) Token: 0x060095A4 RID: 38308 RVA: 0x00046038 File Offset: 0x00044238
		public unsafe VODatabase VoiceDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Voice.NativeFieldInfoPtr_VoiceDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Voice.NativeFieldInfoPtr_VoiceDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x060095A5 RID: 38309 RVA: 0x0028577C File Offset: 0x0028397C
		// (set) Token: 0x060095A6 RID: 38310 RVA: 0x00046057 File Offset: 0x00044257
		public unsafe float VoicePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Voice.NativeFieldInfoPtr_VoicePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Voice.NativeFieldInfoPtr_VoicePitch)) = value;
			}
		}

		// Token: 0x040066FA RID: 26362
		private static readonly IntPtr NativeFieldInfoPtr_VoiceDatabase;

		// Token: 0x040066FB RID: 26363
		private static readonly IntPtr NativeFieldInfoPtr_VoicePitch;

		// Token: 0x040066FC RID: 26364
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Voice_0;

		// Token: 0x040066FD RID: 26365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
