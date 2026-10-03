using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000004 RID: 4
	public class DebugPanelAnimation : MonoBehaviour
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0007BDC0 File Offset: 0x00079FC0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugPanelAnimation()
		{
			Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebugPanelAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr);
			DebugPanelAnimation.NativeFieldInfoPtr_targetImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "targetImage");
			DebugPanelAnimation.NativeFieldInfoPtr_animationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "animationType");
			DebugPanelAnimation.NativeFieldInfoPtr_alphaCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "alphaCurve");
			DebugPanelAnimation.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "duration");
			DebugPanelAnimation.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "timer");
			DebugPanelAnimation.NativeFieldInfoPtr_isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "isPlaying");
			DebugPanelAnimation.NativeFieldInfoPtr_originalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "originalColor");
			DebugPanelAnimation.NativeFieldInfoPtr_originalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, "originalScale");
			DebugPanelAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, 100663303);
			DebugPanelAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, 100663304);
			DebugPanelAnimation.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, 100663305);
			DebugPanelAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr, 100663306);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64820, XrefRangeEnd = 64830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugPanelAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0007BF14 File Offset: 0x0007A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64830, XrefRangeEnd = 64840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugPanelAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0007BF48 File Offset: 0x0007A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64840, XrefRangeEnd = 64844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugPanelAnimation.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0007BF7C File Offset: 0x0007A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64844, XrefRangeEnd = 64847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugPanelAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugPanelAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugPanelAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000213B File Offset: 0x0000033B
		public DebugPanelAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0007BFB8 File Offset: 0x0007A1B8
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002144 File Offset: 0x00000344
		public unsafe Image targetImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_targetImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_targetImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002163 File Offset: 0x00000363
		public unsafe DebugPanelAnimation.AnimationType animationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_animationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_animationType)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0007C010 File Offset: 0x0007A210
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000217E File Offset: 0x0000037E
		public unsafe AnimationCurve alphaCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_alphaCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_alphaCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0007C040 File Offset: 0x0007A240
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000219D File Offset: 0x0000039D
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0007C068 File Offset: 0x0007A268
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000021B8 File Offset: 0x000003B8
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0007C090 File Offset: 0x0007A290
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000021D3 File Offset: 0x000003D3
		public unsafe bool isPlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_isPlaying);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_isPlaying)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0007C0B8 File Offset: 0x0007A2B8
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000021EE File Offset: 0x000003EE
		public unsafe Color originalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_originalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_originalColor)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002209 File Offset: 0x00000409
		public unsafe Vector3 originalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_originalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugPanelAnimation.NativeFieldInfoPtr_originalScale)) = value;
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_targetImage;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_animationType;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_alphaCurve;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_isPlaying;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_originalColor;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_originalScale;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084B RID: 2123
		[OriginalName("Assembly-CSharp.dll", "", "AnimationType")]
		public enum AnimationType
		{
			// Token: 0x04008D64 RID: 36196
			Alpha,
			// Token: 0x04008D65 RID: 36197
			Scale
		}
	}
}
