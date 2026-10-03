using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200046D RID: 1133
	public class AmbientOneShot : MonoBehaviour
	{
		// Token: 0x06006636 RID: 26166 RVA: 0x001DD7E8 File Offset: 0x001DB9E8
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOneShot()
		{
			Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientOneShot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr);
			AmbientOneShot.NativeFieldInfoPtr__volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_volume");
			AmbientOneShot.NativeFieldInfoPtr__playChancePerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_playChancePerHour");
			AmbientOneShot.NativeFieldInfoPtr__cooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_cooldownTime");
			AmbientOneShot.NativeFieldInfoPtr__playTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_playTime");
			AmbientOneShot.NativeFieldInfoPtr__minDistanceFromCameraToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_minDistanceFromCameraToPlay");
			AmbientOneShot.NativeFieldInfoPtr__maxDistanceFromCameraToPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_maxDistanceFromCameraToPlay");
			AmbientOneShot.NativeFieldInfoPtr__canPlayWhilePlayerInSewer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_canPlayWhilePlayerInSewer");
			AmbientOneShot.NativeFieldInfoPtr__timeSinceLastPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_timeSinceLastPlay");
			AmbientOneShot.NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, "_audioSource");
			AmbientOneShot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676699);
			AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676700);
			AmbientOneShot.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676701);
			AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676702);
			AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr, 100676703);
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x001DD930 File Offset: 0x001DBB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213622, XrefRangeEnd = 213626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x001DD964 File Offset: 0x001DBB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213626, XrefRangeEnd = 213639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x001DD998 File Offset: 0x001DBB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213639, XrefRangeEnd = 213670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x001DD9CC File Offset: 0x001DBBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213670, XrefRangeEnd = 213672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x001DDA00 File Offset: 0x001DBC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213672, XrefRangeEnd = 213673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOneShot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOneShot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOneShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x000301FE File Offset: 0x0002E3FE
		public AmbientOneShot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600663D RID: 26173 RVA: 0x001DDA3C File Offset: 0x001DBC3C
		// (set) Token: 0x0600663E RID: 26174 RVA: 0x00030207 File Offset: 0x0002E407
		public unsafe float _volume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__volume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__volume)) = value;
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x001DDA64 File Offset: 0x001DBC64
		// (set) Token: 0x06006640 RID: 26176 RVA: 0x00030222 File Offset: 0x0002E422
		public unsafe float _playChancePerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__playChancePerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__playChancePerHour)) = value;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x001DDA8C File Offset: 0x001DBC8C
		// (set) Token: 0x06006642 RID: 26178 RVA: 0x0003023D File Offset: 0x0002E43D
		public unsafe int _cooldownTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__cooldownTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__cooldownTime)) = value;
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x001DDAB4 File Offset: 0x001DBCB4
		// (set) Token: 0x06006644 RID: 26180 RVA: 0x00030258 File Offset: 0x0002E458
		public unsafe AmbientOneShot.EPlayTime _playTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__playTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__playTime)) = value;
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06006645 RID: 26181 RVA: 0x001DDADC File Offset: 0x001DBCDC
		// (set) Token: 0x06006646 RID: 26182 RVA: 0x00030273 File Offset: 0x0002E473
		public unsafe float _minDistanceFromCameraToPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__minDistanceFromCameraToPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__minDistanceFromCameraToPlay)) = value;
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06006647 RID: 26183 RVA: 0x001DDB04 File Offset: 0x001DBD04
		// (set) Token: 0x06006648 RID: 26184 RVA: 0x0003028E File Offset: 0x0002E48E
		public unsafe float _maxDistanceFromCameraToPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__maxDistanceFromCameraToPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__maxDistanceFromCameraToPlay)) = value;
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x001DDB2C File Offset: 0x001DBD2C
		// (set) Token: 0x0600664A RID: 26186 RVA: 0x000302A9 File Offset: 0x0002E4A9
		public unsafe bool _canPlayWhilePlayerInSewer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__canPlayWhilePlayerInSewer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__canPlayWhilePlayerInSewer)) = value;
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x001DDB54 File Offset: 0x001DBD54
		// (set) Token: 0x0600664C RID: 26188 RVA: 0x000302C4 File Offset: 0x0002E4C4
		public unsafe int _timeSinceLastPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__timeSinceLastPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__timeSinceLastPlay)) = value;
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x001DDB7C File Offset: 0x001DBD7C
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x000302DF File Offset: 0x0002E4DF
		public unsafe AudioSourceController _audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOneShot.NativeFieldInfoPtr__audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004668 RID: 18024
		private static readonly IntPtr NativeFieldInfoPtr__volume;

		// Token: 0x04004669 RID: 18025
		private static readonly IntPtr NativeFieldInfoPtr__playChancePerHour;

		// Token: 0x0400466A RID: 18026
		private static readonly IntPtr NativeFieldInfoPtr__cooldownTime;

		// Token: 0x0400466B RID: 18027
		private static readonly IntPtr NativeFieldInfoPtr__playTime;

		// Token: 0x0400466C RID: 18028
		private static readonly IntPtr NativeFieldInfoPtr__minDistanceFromCameraToPlay;

		// Token: 0x0400466D RID: 18029
		private static readonly IntPtr NativeFieldInfoPtr__maxDistanceFromCameraToPlay;

		// Token: 0x0400466E RID: 18030
		private static readonly IntPtr NativeFieldInfoPtr__canPlayWhilePlayerInSewer;

		// Token: 0x0400466F RID: 18031
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastPlay;

		// Token: 0x04004670 RID: 18032
		private static readonly IntPtr NativeFieldInfoPtr__audioSource;

		// Token: 0x04004671 RID: 18033
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004672 RID: 18034
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004673 RID: 18035
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Private_Void_0;

		// Token: 0x04004674 RID: 18036
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x04004675 RID: 18037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B46 RID: 2886
		[OriginalName("Assembly-CSharp.dll", "", "EPlayTime")]
		public enum EPlayTime
		{
			// Token: 0x04009CE5 RID: 40165
			All,
			// Token: 0x04009CE6 RID: 40166
			Day,
			// Token: 0x04009CE7 RID: 40167
			Night
		}
	}
}
