using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x0200012E RID: 302
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x000DE4F8 File Offset: 0x000DC6F8
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAudio()
		{
			Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr);
			SkateboardAudio.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "Board");
			SkateboardAudio.NativeFieldInfoPtr_JumpAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "JumpAudio");
			SkateboardAudio.NativeFieldInfoPtr_LandAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "LandAudio");
			SkateboardAudio.NativeFieldInfoPtr_RollingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "RollingAudio");
			SkateboardAudio.NativeFieldInfoPtr_DirtRollingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "DirtRollingAudio");
			SkateboardAudio.NativeFieldInfoPtr_WindAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "WindAudio");
			SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667217);
			SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667218);
			SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667219);
			SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667220);
			SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667221);
			SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667222);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000DE618 File Offset: 0x000DC818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104757, XrefRangeEnd = 104782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000DE64C File Offset: 0x000DC84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104782, XrefRangeEnd = 104787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000DE680 File Offset: 0x000DC880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104787, XrefRangeEnd = 104798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000DE6B4 File Offset: 0x000DC8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104798, XrefRangeEnd = 104801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayJump(float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000DE6F4 File Offset: 0x000DC8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104801, XrefRangeEnd = 104802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000DE728 File Offset: 0x000DC928
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00010599 File Offset: 0x0000E799
		public SkateboardAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000DE764 File Offset: 0x000DC964
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x000105A2 File Offset: 0x0000E7A2
		public unsafe Skateboard Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000DE794 File Offset: 0x000DC994
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x000105C1 File Offset: 0x0000E7C1
		public unsafe AudioSourceController JumpAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000DE7C4 File Offset: 0x000DC9C4
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x000105E0 File Offset: 0x0000E7E0
		public unsafe AudioSourceController LandAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x000DE7F4 File Offset: 0x000DC9F4
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x000105FF File Offset: 0x0000E7FF
		public unsafe AudioSourceController RollingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x000DE824 File Offset: 0x000DCA24
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0001061E File Offset: 0x0000E81E
		public unsafe AudioSourceController DirtRollingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_DirtRollingAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_DirtRollingAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000DE854 File Offset: 0x000DCA54
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0001063D File Offset: 0x0000E83D
		public unsafe AudioSourceController WindAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeFieldInfoPtr_JumpAudio;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeFieldInfoPtr_LandAudio;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeFieldInfoPtr_RollingAudio;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeFieldInfoPtr_DirtRollingAudio;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeFieldInfoPtr_WindAudio;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_PlayJump_Public_Void_Single_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_PlayLand_Public_Void_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
