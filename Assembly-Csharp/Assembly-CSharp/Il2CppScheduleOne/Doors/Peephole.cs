using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003AB RID: 939
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06005574 RID: 21876 RVA: 0x001A3334 File Offset: 0x001A1534
		// Note: this type is marked as 'beforefieldinit'.
		static Peephole()
		{
			Il2CppClassPointerStore<Peephole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "Peephole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Peephole>.NativeClassPtr);
			Peephole.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "DoorAnim");
			Peephole.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "OpenSound");
			Peephole.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "CloseSound");
			Peephole.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100674503);
			Peephole.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100674504);
			Peephole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100674505);
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x001A33DC File Offset: 0x001A15DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189439, RefRangeEnd = 189440, XrefRangeStart = 189435, XrefRangeEnd = 189439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x001A3410 File Offset: 0x001A1610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189444, RefRangeEnd = 189445, XrefRangeStart = 189440, XrefRangeEnd = 189444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x001A3444 File Offset: 0x001A1644
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Peephole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Peephole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x000285CA File Offset: 0x000267CA
		public Peephole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x001A3480 File Offset: 0x001A1680
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x000285D3 File Offset: 0x000267D3
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x001A34B0 File Offset: 0x001A16B0
		// (set) Token: 0x0600557C RID: 21884 RVA: 0x000285F2 File Offset: 0x000267F2
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x001A34E0 File Offset: 0x001A16E0
		// (set) Token: 0x0600557E RID: 21886 RVA: 0x00028611 File Offset: 0x00026811
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003AEC RID: 15084
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04003AED RID: 15085
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04003AEE RID: 15086
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04003AEF RID: 15087
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04003AF0 RID: 15088
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04003AF1 RID: 15089
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
