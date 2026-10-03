using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003AA RID: 938
	public class ManholeCoverMovement : MonoBehaviour
	{
		// Token: 0x0600556D RID: 21869 RVA: 0x001A31E0 File Offset: 0x001A13E0
		// Note: this type is marked as 'beforefieldinit'.
		static ManholeCoverMovement()
		{
			Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "ManholeCoverMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr);
			ManholeCoverMovement.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr, "Anim");
			ManholeCoverMovement.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr, 100674500);
			ManholeCoverMovement.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr, 100674501);
			ManholeCoverMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr, 100674502);
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x001A3260 File Offset: 0x001A1460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189408, XrefRangeEnd = 189420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCoverMovement.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x001A3294 File Offset: 0x001A1494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189420, XrefRangeEnd = 189435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCoverMovement.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x001A32C8 File Offset: 0x001A14C8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManholeCoverMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManholeCoverMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCoverMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x000285A2 File Offset: 0x000267A2
		public ManholeCoverMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06005572 RID: 21874 RVA: 0x001A3304 File Offset: 0x001A1504
		// (set) Token: 0x06005573 RID: 21875 RVA: 0x000285AB File Offset: 0x000267AB
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCoverMovement.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCoverMovement.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003AE8 RID: 15080
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04003AE9 RID: 15081
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04003AEA RID: 15082
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04003AEB RID: 15083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
