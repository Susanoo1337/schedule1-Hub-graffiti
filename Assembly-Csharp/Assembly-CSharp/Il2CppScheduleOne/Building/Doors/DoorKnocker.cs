using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x0200046B RID: 1131
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x06006615 RID: 26133 RVA: 0x001DD174 File Offset: 0x001DB374
		// Note: this type is marked as 'beforefieldinit'.
		static DoorKnocker()
		{
			Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "DoorKnocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr);
			DoorKnocker.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "Anim");
			DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSoundClipName");
			DoorKnocker.NativeFieldInfoPtr_KnockingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSound");
			DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676686);
			DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676687);
			DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100676688);
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x001DD21C File Offset: 0x001DB41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213510, XrefRangeEnd = 213514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x001DD250 File Offset: 0x001DB450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213514, XrefRangeEnd = 213516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayKnockingSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x001DD284 File Offset: 0x001DB484
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorKnocker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006619 RID: 26137 RVA: 0x00030111 File Offset: 0x0002E311
		public DoorKnocker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x001DD2C0 File Offset: 0x001DB4C0
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x0003011A File Offset: 0x0002E31A
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x001DD2F0 File Offset: 0x001DB4F0
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x00030139 File Offset: 0x0002E339
		public unsafe string KnockingSoundClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x001DD318 File Offset: 0x001DB518
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x00030158 File Offset: 0x0002E358
		public unsafe AudioSource KnockingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004653 RID: 18003
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04004654 RID: 18004
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSoundClipName;

		// Token: 0x04004655 RID: 18005
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSound;

		// Token: 0x04004656 RID: 18006
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Public_Void_0;

		// Token: 0x04004657 RID: 18007
		private static readonly IntPtr NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0;

		// Token: 0x04004658 RID: 18008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
