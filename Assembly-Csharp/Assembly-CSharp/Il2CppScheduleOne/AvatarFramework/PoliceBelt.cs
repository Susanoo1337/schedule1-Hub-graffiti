using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020004A1 RID: 1185
	public class PoliceBelt : Accessory
	{
		// Token: 0x06006C85 RID: 27781 RVA: 0x001F2624 File Offset: 0x001F0824
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceBelt()
		{
			Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "PoliceBelt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr);
			PoliceBelt.NativeFieldInfoPtr_BatonObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "BatonObject");
			PoliceBelt.NativeFieldInfoPtr_TaserObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "TaserObject");
			PoliceBelt.NativeFieldInfoPtr_GunObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, "GunObject");
			PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100677478);
			PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100677479);
			PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100677480);
			PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr, 100677481);
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x001F26E0 File Offset: 0x001F08E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221318, RefRangeEnd = 221319, XrefRangeStart = 221315, XrefRangeEnd = 221318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBatonVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x001F2720 File Offset: 0x001F0920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221322, RefRangeEnd = 221323, XrefRangeStart = 221319, XrefRangeEnd = 221322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTaserVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x001F2760 File Offset: 0x001F0960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221326, RefRangeEnd = 221327, XrefRangeStart = 221323, XrefRangeEnd = 221326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGunVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x001F27A0 File Offset: 0x001F09A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceBelt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceBelt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceBelt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00033303 File Offset: 0x00031503
		public PoliceBelt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x001F27DC File Offset: 0x001F09DC
		// (set) Token: 0x06006C8C RID: 27788 RVA: 0x0003330C File Offset: 0x0003150C
		public unsafe GameObject BatonObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_BatonObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06006C8D RID: 27789 RVA: 0x001F280C File Offset: 0x001F0A0C
		// (set) Token: 0x06006C8E RID: 27790 RVA: 0x0003332B File Offset: 0x0003152B
		public unsafe GameObject TaserObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_TaserObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06006C8F RID: 27791 RVA: 0x001F283C File Offset: 0x001F0A3C
		// (set) Token: 0x06006C90 RID: 27792 RVA: 0x0003334A File Offset: 0x0003154A
		public unsafe GameObject GunObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceBelt.NativeFieldInfoPtr_GunObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A99 RID: 19097
		private static readonly IntPtr NativeFieldInfoPtr_BatonObject;

		// Token: 0x04004A9A RID: 19098
		private static readonly IntPtr NativeFieldInfoPtr_TaserObject;

		// Token: 0x04004A9B RID: 19099
		private static readonly IntPtr NativeFieldInfoPtr_GunObject;

		// Token: 0x04004A9C RID: 19100
		private static readonly IntPtr NativeMethodInfoPtr_SetBatonVisible_Public_Void_Boolean_0;

		// Token: 0x04004A9D RID: 19101
		private static readonly IntPtr NativeMethodInfoPtr_SetTaserVisible_Public_Void_Boolean_0;

		// Token: 0x04004A9E RID: 19102
		private static readonly IntPtr NativeMethodInfoPtr_SetGunVisible_Public_Void_Boolean_0;

		// Token: 0x04004A9F RID: 19103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
